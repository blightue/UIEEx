using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace SuiSuiShou.UIEEx.Editor
{
    public class SummaryXMLAnalyzer : EditorWindow
    {
        [FormerlySerializedAs("xmlFilePath")] [SerializeField] private string engineXMLFilePath;
        [SerializeField] private string editorXMLFilePath;
        [SerializeField] private UIEControlsNameSO controlsNameSO;

        [MenuItem("Window/UI Toolkit/UIEEx/Code Gen/SummaryXML Analyzer")]
        private static void ShowWindow()
        {
            var window = GetWindow<SummaryXMLAnalyzer>();
            window.titleContent = new GUIContent("SummaryXML Analyzer");
            window.Show();
        }

        private void OnGUI()
        {
            controlsNameSO = (UIEControlsNameSO) EditorGUILayout.ObjectField
                ("Controls Name SO", controlsNameSO, typeof(UIEControlsNameSO), false);
            
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Engine XML file path", EditorStyles.boldLabel);
            bool isEngine = GUILayout.Button("Select");
            EditorGUILayout.EndHorizontal();
            if (isEngine)
                engineXMLFilePath =
                    EditorUtility.OpenFilePanel("Select Engine XML file path", Application.dataPath, "");
            engineXMLFilePath = EditorGUILayout.TextArea(engineXMLFilePath);
            
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Editor XML file path", EditorStyles.boldLabel);
            bool isEditor = GUILayout.Button("Select");
            EditorGUILayout.EndHorizontal();
            if (isEditor)
                editorXMLFilePath =
                    EditorUtility.OpenFilePanel("Select Editor XML file path", Application.dataPath, "");
            editorXMLFilePath = EditorGUILayout.TextArea(editorXMLFilePath);
            
            if(GUILayout.Button("Analyze"))
                Analyze();
        }

        private void Analyze()
        {
            string[] engineControlsName = controlsNameSO.EngineControlsNames;
            string[] editorControlsName = controlsNameSO.EditorControlsNames;

            string[] xmlEngineFileLines = System.IO.File.ReadAllLines(engineXMLFilePath);
            int[] engineCtorIndices = GetConstroctorLineIndex(xmlEngineFileLines);
            string[] engineCtorLines = engineCtorIndices.Select(i => xmlEngineFileLines[i]).ToArray();
            
            string[] xmlEditorFileLines = System.IO.File.ReadAllLines(editorXMLFilePath);
            int[] editorCtorIndices = GetConstroctorLineIndex(xmlEditorFileLines);  
            string[] editorCtorLines = editorCtorIndices.Select(i => xmlEditorFileLines[i]).ToArray();

            foreach (string controlName in engineControlsName)
            {
                int[] indices = GetConstroctorLineIndex(engineCtorLines, controlName, xmlEngineFileLines);
                if(indices.Length == 0)
                    Debug.LogError($"Not find {controlName}");
                else
                    Debug.Log($"Find {indices.Length} {controlName}");
            }
            
            foreach (string controlName in editorControlsName)
            {
                int[] indices = GetConstroctorLineIndex(editorCtorLines, controlName, xmlEditorFileLines);
                if(indices.Length == 0)
                    Debug.LogError($"Not find {controlName}");
                else
                    Debug.Log($"Find {indices.Length} {controlName}");
            }
            
            Debug.Log($"Found constroctor xml count: {engineCtorIndices.Length}");
        }

        private int[] GetConstroctorLineIndex(string[] xmlLines, string typeFullName = null, string[] callbackLines = null)
        {
            int[] indices;
            if (typeFullName == null)
            {
                indices = Enumerable.Range(0, xmlLines.Length)
                    .Where(i => xmlLines[i].Contains("#ctor"))
                    .ToArray();
            }
            else
            {
                indices = Enumerable.Range(0, xmlLines.Length)
                    .Where(i =>
                        xmlLines[i].Contains($"M:{typeFullName}.#ctor"))
                    .ToArray();
            }

            if (indices.Length == 0 && callbackLines != null)
            {
                Debug.LogWarning($"Find no constroctor xml for {typeFullName} trying callback summary");
                indices = Enumerable.Range(0, callbackLines .Length)
                    .Where(i =>
                        callbackLines[i].Contains($"T:{typeFullName}"))
                    .ToArray();
            }

            return indices;
        }
    }
}