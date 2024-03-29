﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace SuiSuiShou.UIEEx.CodeGenerator
{
    public class UIELayoutCodeGenWindow : EditorWindow
    {
        [SerializeField] private UIEControlsNameSO controlsNameSO;
        [SerializeField] private UIEControlsSummarySO controlsSummarySO;
        [SerializeField] private string UIEExEnginePath;
        [SerializeField] private string UIEExEditorPath;

        private readonly string ScriptHint =
            $"/*\nThis script is auto generated by {nameof(UIELayoutCodeGenWindow)}\n\n" +
            "Copyright 2023 SUISUISHOU(blightue@gmail.com)\n\n" +
            "Licensed under the Apache License, Version 2.0 (the \"License\")\n" +
            "you may not use this file except in compliance with the License.\n" +
            "You may obtain a copy of the License at\n\n" +
            "     http://www.apache.org/licenses/LICENSE-2.0\n\n" +
            "Unless required by applicable law or agreed to in writing, software\n" +
            "distributed under the License is distributed on an \"AS IS\" BASIS,\n" +
            "WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\n" +
            "See the License for the specific language governing permissions and\n" +
            "limitations under the License.\n*/\n\n";

        [MenuItem("Window/UI Toolkit/UIEEx/Code Gen/Code Generator")]
        private static void ShowWindow()
        {
            var window = GetWindow<UIELayoutCodeGenWindow>();
            window.titleContent = new GUIContent("Code Generator");
            window.Show();
        }

        private void OnGUI()
        {
            controlsNameSO =
                (UIEControlsNameSO) EditorGUILayout.ObjectField
                    ("Controls Name", controlsNameSO, typeof(UIEControlsNameSO), false);
            controlsSummarySO =
                (UIEControlsSummarySO)EditorGUILayout.ObjectField
                    ("Controls Summary", controlsSummarySO, typeof(UIEControlsSummarySO), false);
                EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Engine Folder", EditorStyles.boldLabel);
            bool isEngineFolder = GUILayout.Button("Select");
            EditorGUILayout.EndHorizontal();
            if (isEngineFolder)
                UIEExEnginePath =
                    EditorUtility.OpenFolderPanel("Select Engine Scripts Folder", Application.dataPath, "");
            UIEExEnginePath = EditorGUILayout.TextArea(UIEExEnginePath);


            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Editor Folder", EditorStyles.boldLabel);
            bool isEditorFolder = GUILayout.Button("Select");
            EditorGUILayout.EndHorizontal();
            if (isEditorFolder)
                UIEExEditorPath =
                    EditorUtility.OpenFolderPanel("Select Editor Scripts Folder", Application.dataPath, "");
            UIEExEditorPath = EditorGUILayout.TextArea(UIEExEditorPath);

            if (GUILayout.Button("Generate Scripts")) GenerateScripts();
        }

        private void GenerateScripts()
        {
            ControlElement[] engineElements = controlsNameSO.EngineElements;
            ControlElement[] editorElements = controlsNameSO.EditorElements;

            WriteScriptFile(engineElements, controlsSummarySO.EngineControlsMap, UIEExEnginePath);
            WriteScriptFile(editorElements, controlsSummarySO.EditorControlsMap, UIEExEditorPath);

            AssetDatabase.Refresh();
        }

        #region Get Types


        #endregion

        #region Scripts Generate

        private string GenerateScript(ControlElement element, SummaryContent summaries)
        {
            ConstructorInfo[] constructors = element.Type.GetConstructors();

            string typeName = element.Type.Name;
            string instanceName = Type2Instance(typeName);
            string className = element.ClassName;

            string script =
                ScriptHint +
                (element.IsEditor ? "using UnityEditor.UIElements;\n" : null) +
                "using UnityEngine.UIElements;\n" +
                "using SuiSuiShou.UIEEx;\n\n" +
                $"namespace {element.NameSpace}\n" +
                "{\n" +
                $"    public static partial class {className} \n" +
                "    {\n" +
                GenerateConstructors(constructors, summaries, typeName, instanceName) +
                "    }\n" +
                "}";
            
            return script;
        }

        private string GenerateConstructors(ConstructorInfo[] infors, SummaryContent summaries, string typeName, string instanceName)
        {
            StringBuilder result = new StringBuilder();
            
            if(summaries == null) Debug.LogError($"{typeName} is null");
            if(summaries.CtorSummaries == null) Debug.LogError($"{typeName} ctor is null");
            
            List<string> ctorSummaries = summaries.CtorSummaries.ToList();

            if (infors.Length != ctorSummaries.Count)
            {
                if(infors.Length == ctorSummaries.Count + 1)
                    ctorSummaries.Add(summaries.TypeSummary);
                else
                    Debug.LogError
                    ($"Type {typeName} Elements ctor length [{infors.Length}] != summaries length [{ctorSummaries.Count}]");
            }

            for (int i = 0; i < infors.Length; i++)
            {
                ConstructorInfo infor = infors[i];
                string summary = ctorSummaries[i];
                result.Append(GenerateConstructor(infor, summary, typeName, instanceName));
            }

            return result.ToString();
        }

        private string GenerateConstructor(ConstructorInfo constructorInfo, string summary, string typeName, string instanceName)
        {
            return
                AddSummaryParent(summary) +
                $"        public static {typeName} {typeName} ({GenerateConstructorParameters(constructorInfo)})\n" +
                "        {{\n" +
                $"            {typeName} {instanceName} = new {typeName}({GetConstructorParameters(constructorInfo)});\n" +
                $"            {instanceName}.SetParent(parent);\n" +
                $"            return {instanceName};\n" +
                "        }}\n\n";
        }

        private string GenerateConstructorParameters(ConstructorInfo constructor)
        {
            StringBuilder result = new StringBuilder();

            foreach (ParameterInfo parameter in constructor.GetParameters())
            {
                result.Append($"{GetRealTypeName(parameter.ParameterType)} {parameter.Name}, ");
            }

            result.Append("VisualElement parent = null");
            return result.ToString();
        }

        private string GetConstructorParameters(ConstructorInfo constructor)
        {
            ParameterInfo[] parameters = constructor.GetParameters();
            if (parameters.Length == 0) return string.Empty;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < parameters.Length - 1; i++)
            {
                result.Append($"{parameters[i].Name}, ");
            }

            result.Append(parameters[^1].Name);

            return result.ToString();
        }

        #endregion

        #region Write Script Files

        private void WriteScriptFile(ControlElement[] elements, Dictionary<string, SummaryContent> nameSummaryMap, string folderPath)
        {
            if (elements.Length != nameSummaryMap.Count)
            {
                Debug.LogError($"Elements count {elements.Length} != summary count {nameSummaryMap.Count}");
                return;
            }
            
            foreach (ControlElement element in elements)
            {
                WriteScriptFile
                (
                    GenerateScript(element, nameSummaryMap[element.Type.FullName]),
                    folderPath,
                    element.Type.Name.Split('.')[^1]
                );
            }
        }

        private void WriteScriptFile(string content, string folderPath, string fileName)
        {
            string path = $"{folderPath}/{fileName}.cs";
            
            

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                fs.SetLength(0);
                fs.Flush();
                
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(content);
                }
            }
        }

        #endregion


        #region Utility

        private string Type2Instance(string typeName)
        {
            return char.ToLower(typeName[0]) + typeName.Substring(1);
        }

        public string GetRealTypeName(Type t)
        {
            string fullName = t.FullName;
            if (!t.IsGenericType)
                return fullName;

            StringBuilder sb = new StringBuilder();
            sb.Append(fullName.Substring(0, fullName.IndexOf('`')));
            sb.Append('<');
            bool appendComma = false;
            foreach (Type arg in t.GetGenericArguments())
            {
                if (appendComma) sb.Append(',');
                sb.Append(GetRealTypeName(arg));
                appendComma = true;
            }

            sb.Append('>');
            return sb.ToString();
        }

        private string AddSummaryParent(string summary)
        {
            string parent = "\n///<param name=\"parent\">The parent of this element.</param>\n";
            return summary + parent;
        }

        #endregion
    }
}