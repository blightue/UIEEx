using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace SuiSuiShou.UIEEx.Editor
{
    public class ElementNameFilter : EditorWindow
    {
        private string inputName;
        [SerializeField] private UIETypeNameSO targetNames;
        
        [MenuItem("Tools/UIEEx/Code Gen/Element Name Filter")]
        private static void ShowWindow()
        {
            var window = GetWindow<ElementNameFilter>();
            window.titleContent = new GUIContent("Element Name Filter");
            window.Show();
        }

        private void OnGUI()
        {
            targetNames = (UIETypeNameSO) EditorGUILayout.ObjectField
                ("Target Names", targetNames, typeof(UIETypeNameSO), false);
            inputName = EditorGUILayout.TextField("Element Name", inputName);
            
            if(GUILayout.Button("Write To Name SO"))
            {
                WriteToNameSO();
            }
        }
        
        private void WriteToNameSO()
        {
            string[] inputNames = inputName.Split(" ");
            inputNames = inputNames
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(a => a.Split(("."))[^1])
                .ToArray();

            List<string> engineTypes = new List<string>();
            List<string> editorTypes = new List<string>();

            FilterNames(inputNames, engineTypes, editorTypes);
            
            targetNames.EngineElementTypeNames = engineTypes.ToArray();
            targetNames.EditorElementTypeNames = editorTypes.ToArray();
            
            EditorUtility.SetDirty(targetNames);
        }

        private void FilterNames(string[] inputNames, List<string> engineTypes, List<string> editorTypes)
        {
            Assembly engineAssembly = Assembly.Load("UnityEngine.UIElementsModule");
            Assembly editorAssembly = Assembly.Load("UnityEditor.UIElementsModule");

            foreach (string typeName in inputNames)
            {
                if(engineAssembly.GetType("UnityEngine.UIElements." + typeName) != null)
                {
                    engineTypes.Add("UnityEngine.UIElements." + typeName);
                }
                else if(editorAssembly.GetType("UnityEditor.UIElements." + typeName) != null)
                {
                    editorTypes.Add("UnityEditor.UIElements." + typeName);
                }
                else
                {
                    Debug.LogWarning($"Can not find type {typeName} in engine or editor assembly");
                }
            }
        }
    }
}