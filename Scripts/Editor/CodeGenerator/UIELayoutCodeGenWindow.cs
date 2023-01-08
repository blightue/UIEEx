﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace SuiSuiShou.UIEEx.Editor
{
    public class UIELayoutCodeGenWindow : EditorWindow
    {
        [SerializeField] private UIETypeNameSO elementsNameSO;
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

        [MenuItem("Tools/UIEEx/Code Gen/Code Generator")]
        private static void ShowWindow()
        {
            var window = GetWindow<UIELayoutCodeGenWindow>();
            window.titleContent = new GUIContent("Code Generator");
            window.Show();
        }

        private void OnGUI()
        {
            elementsNameSO =
                (UIETypeNameSO) EditorGUILayout.ObjectField("Elements", elementsNameSO, typeof(UIETypeNameSO), false);

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
            GenerateElement[] engineElements = GetEngineElements(elementsNameSO.EngineElementTypeNames);
            GenerateElement[] editorElements = GetEditorElements(elementsNameSO.EditorElementTypeNames);

            WriteScriptFile(engineElements, UIEExEnginePath);
            WriteScriptFile(editorElements, UIEExEditorPath);

            AssetDatabase.Refresh();
        }

        #region Get Types

        private GenerateElement[] GetEngineElements(string[] typeNames)
        {
            Assembly engineAssembly = Assembly.Load("UnityEngine.UIElementsModule");
            GenerateElement[] result = new GenerateElement[typeNames.Length];
            for (int i = 0; i < typeNames.Length; i++)
            {
                result[i] = new GenerateElement
                (
                    engineAssembly.GetType(typeNames[i], true, true),
                    "UIELayout",
                    "SuiSuiShou.UIEEx",
                    false
                );
            }

            return result;
        }

        private GenerateElement[] GetEditorElements(string[] typeNames)
        {
            Assembly editorAssembly = Assembly.Load("UnityEditor.UIElementsModule");
            GenerateElement[] result = new GenerateElement[typeNames.Length];
            for (int i = 0; i < typeNames.Length; i++)
            {
                result[i] = new GenerateElement
                (
                    editorAssembly.GetType(typeNames[i], true, true),
                    "EditorUIELayout",
                    "SuiSuiShou.UIEEx.Editor",
                    true
                );
            }

            return result;
        }

        #endregion

        #region Scripts Generate

        private string GenerateScript(GenerateElement element)
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
                GenerateConstructors(constructors, typeName, instanceName) +
                "    }\n" +
                "}";
            
            return script;
        }

        private string GenerateConstructors(ConstructorInfo[] infors, string typeName, string instanceName)
        {
            StringBuilder result = new StringBuilder();
            foreach (ConstructorInfo infor in infors)
            {
                result.Append(GenerateConstructor(infor, typeName, instanceName));
            }

            return result.ToString();
        }

        private string GenerateConstructor(ConstructorInfo constructorInfo, string typeName, string instanceName)
        {
            return
                $"        public static {typeName} {typeName} ({GenerateConstructorParameters(constructorInfo)})\n" +
                $"        {{\n" +
                $"            {typeName} {instanceName} = new {typeName}({GetConstructorParameters(constructorInfo)});\n" +
                $"            {instanceName}.SetParent(parent);\n" +
                $"            return {instanceName};\n" +
                $"        }}\n\n";
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

        private void WriteScriptFile(GenerateElement[] elements, string folderPath)
        {
            foreach (GenerateElement element in elements)
            {
                WriteScriptFile
                (
                    GenerateScript(element),
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

        #endregion
    }

    #region Data Struct

    [Serializable]
    public class GenerateElement
    {
        public Type Type;
        public string ClassName;
        public string NameSpace;
        public bool IsEditor;

        public GenerateElement(Type type, string className, string nameSpace, bool isEditor)
        {
            Type = type;
            ClassName = className;
            NameSpace = nameSpace;
            IsEditor = isEditor;
        }
    }

    #endregion
}