using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx.Editor
{
    [Obsolete]
    public class SummaryAnaylzer : EditorWindow
    {
        private static Dictionary<string, string> BaseDataShortNameMap = new Dictionary<string, string>()
        {
            {"System.Boolean", "bool"},
            {"System.Byte", "byte"},
            {"System.SByte", "sbyte"},
            {"System.Char", "char"},
            {"System.Decimal", "decimal"},
            {"System.Double", "double"},
            {"System.Single", "float"},
            {"System.Int32", "int"},
            {"System.UInt32", "uint"},
            {"System.Int64", "long"},
            {"System.UInt64", "ulong"},
            {"System.Int16", "short"},
            {"System.UInt16", "ushort"},
            {"System.Object", "object"},
            {"System.String", "string"}
        };

        [SerializeField] UIEControlsNameSO elementsNameSO;


        
        // [SerializeField] private string sourceCodePath;
        [SerializeField] private string sourceEngineFolder;
        [SerializeField] private string sourceEditorFolder;

        [MenuItem("Window/UI Toolkit/UIEEx/Code Gen/Summary Anaylzer")]
        private static void ShowWindow()
        {
            var window = GetWindow<SummaryAnaylzer>();
            window.titleContent = new GUIContent("Summary Anaylzer");
            window.Show();
        }

        private void OnGUI()
        {
            elementsNameSO =
                (UIEControlsNameSO) EditorGUILayout.ObjectField
                    ("Elements", elementsNameSO, typeof(UIEControlsNameSO), false);

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Engine Folder", EditorStyles.boldLabel);
            bool isEngineFolder = GUILayout.Button("Select");
            EditorGUILayout.EndHorizontal();
            if (isEngineFolder)
                sourceEngineFolder =
                    EditorUtility.OpenFolderPanel("Select Engine Scripts Folder", Application.dataPath, "");
            sourceEngineFolder = EditorGUILayout.TextArea(sourceEngineFolder);


            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Editor Folder", EditorStyles.boldLabel);
            bool isEditorFolder = GUILayout.Button("Select");
            EditorGUILayout.EndHorizontal();
            if (isEditorFolder)
                sourceEditorFolder =
                    EditorUtility.OpenFolderPanel("Select Editor Scripts Folder", Application.dataPath, "");
            sourceEditorFolder = EditorGUILayout.TextArea(sourceEditorFolder);

            if (GUILayout.Button("Get Code Type Pair"))
            {
                //AnylazingSourceCode(GetSourceCode(sourceCodePath), typeof(Button));
                GetCodeTypePairs();
            }
        }


        private string[] GetSourceCode(string path)
        {
            return File.ReadLines(path).ToArray();
        }

        private void GetCodeTypePairs()
        {
            Dictionary<Type, string[]> engineCodeTypePairs = FindSrcTypePairs
                (sourceEngineFolder, elementsNameSO.EngineElements.Select(e => e.Type).ToArray());
            Dictionary<Type, string[]> editorCodeTypePairs = FindSrcTypePairs
                (sourceEditorFolder, elementsNameSO.EditorElements.Select(e => e.Type).ToArray());
            
            foreach (KeyValuePair<Type, string[]> codeTypePair in engineCodeTypePairs)
            {
                AnylazingSourceCode(codeTypePair.Value, codeTypePair.Key);
            }
        }
        
        private Dictionary<Type, string[]> FindSrcTypePairs(string folderPath, Type[] types)
        {
            Dictionary<Type, string[]> result = new Dictionary<Type, string[]>();

            string[] fileNames =
                Directory.GetFiles(folderPath)
                    .Select(path => path.Split("\\")[^1])
                    .Select(a => a.Split('.')[0])
                    .ToArray();

            foreach (Type type in types)
            {
                string fileName = fileNames.FirstOrDefault(fileName => fileName == type.Name);
                if (fileName != null)
                {
                    result.Add(type, GetSourceCode(Path.Combine(folderPath, fileName + ".cs")));
                }
                else
                {
                    Debug.LogError($"Can't find {type.Name} in {folderPath}");
                }
            }

            return result;
        }

        private void AnylazingSourceCode(string[] sourceCode, Type type)
        {
            var constructInfo = type.GetConstructors();

            foreach (var info in constructInfo)
            {
                var parameters = info.GetParameters();

                string constructorHead = GetConstroctorHead(type, parameters);

                int lineIndex = Array.FindIndex(sourceCode, line => line.Contains(constructorHead, StringComparison.OrdinalIgnoreCase));

                string summary = GetSummary(sourceCode, lineIndex);
                if (lineIndex > 0)
                    Debug.Log(
                        $"Find Constructor {sourceCode[lineIndex]} in line {lineIndex}\nwith summary:\n{summary}");
                else
                    Debug.Log($"Can not find construstor {constructorHead} in source code");
            }
        }
        
        private string GetConstroctorHead(Type type, ParameterInfo[] parameters)
        {
            string result = "public " + type.Name + "(";
            if (parameters.Length > 0)
            {
                if (parameters.Length == 1)
                {
                    result += GetTypeName(parameters[0].ParameterType) + " " + parameters[0].Name;
                }
                else
                {
                    for (int i = 0; i < parameters.Length - 1; i++)
                    {
                        result += GetTypeName(parameters[i].ParameterType) + " " + parameters[i].Name + ", ";
                    }
                    result += GetTypeName(parameters[^1].ParameterType) + " " + parameters[^1].Name;
                }
            }
            result += ")";
            return result;
        }

        private string GetTypeName(Type type)
        {
            bool isGeneric = type.IsGenericType;
            
            if (isGeneric)
            {
                StringBuilder typeName = new StringBuilder();
                typeName.Append(type.Name.Split('`')[0]);
                typeName.Append("<");
                string[] genericNames = type.GetGenericArguments()
                    .Select(t => GetTypeName(t)).ToArray();

                if (genericNames.Length > 1)
                {
                    foreach (string gName in genericNames[..^1])
                    {
                        typeName.Append(gName + ", ");
                    }
                }
                typeName.Append(genericNames[^1] + ">");

                return typeName.ToString();
            }
            else
            {
                return GetTypeShortName(type);
            }
        }
        
        private string GetTypeShortName(Type type)
        {
            string fullName = type.FullName;
            if (BaseDataShortNameMap.ContainsKey(fullName))
                return BaseDataShortNameMap[fullName];
            else
                return fullName;
        }

        private string GetSummary(string[] sourceCode, int lineIndex, int tabCount = 0)
        {
            string summary = "";
            for (int i = lineIndex - 1; i >= 0; i--)
            {
                string noTab = RemoveTab(sourceCode[i]);
                if (noTab.StartsWith("///"))
                {
                    summary += noTab + '\n';
                }
                else
                {
                    if (summary != string.Empty)
                    {
                        summary = summary.Remove(summary.Length - 1);
                    }

                    break;
                }
            }
            
            return AddTab(summary, tabCount);
        }

        private string RemoveTab(string input)
        {
            StringBuilder result = new StringBuilder(input);

            int spaceLength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    spaceLength += 1;
                else
                    break;
            }

            result.Remove(0, spaceLength);
            return result.ToString();
        }

        private string AddTab(string input, int tabCount)
        {
            string[] lines = input.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = new string(' ', tabCount * 4) + lines[i];
            }

            return string.Join('\n', lines);
        }
    }
}