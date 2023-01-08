using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx.Editor
{
    public class SummaryAnaylzer : EditorWindow
    {
        [SerializeField] private string sourceCodePath;
        
        [MenuItem("Tools/UIEEx/Code Gen/Summary Anaylzer")]
        private static void ShowWindow()
        {
            var window = GetWindow<SummaryAnaylzer>();
            window.titleContent = new GUIContent("Summary Anaylzer");
            window.Show();
        }
        
        private void OnGUI()
        {
            sourceCodePath = EditorGUILayout.TextField("Source Code Path", sourceCodePath);
            
            if (GUILayout.Button("Anylaze"))
            {
                AnylazingSourceCode(GetSourceCode(sourceCodePath), typeof(Button));
            }

        }
        
        
        private string[] GetSourceCode(string path)
        {
            return File.ReadLines(path).ToArray();
        }
        
        private void AnylazingSourceCode(string[] sourceCode, Type type)
        {
            var constructInfo = type.GetConstructors();
            
            foreach (var info in constructInfo)
            {
                var parameters = info.GetParameters();
                
                string constructorCode = "public " + type.Name + "(";
                foreach (var parameter in parameters)
                {
                    constructorCode += "" + parameter.ParameterType.Name + " " + parameter.Name + ", ";
                }

                if (parameters.Length > 0)
                {
                    constructorCode = constructorCode.Remove(constructorCode.Length - 1);
                    constructorCode = constructorCode.Remove(constructorCode.Length - 1);
                }
                constructorCode += ")";
                int lineIndex = Array.FindIndex(sourceCode, line => line.Contains(constructorCode));
                if(lineIndex > 0)
                    Debug.Log($"Find Constructor {sourceCode[lineIndex]} in line {lineIndex}");
                else
                    Debug.Log($"Can not find construstor {constructorCode} in source code");
            }
        }
    }
}