using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using System.Xml;

namespace SuiSuiShou.UIEEx.Editor
{
    public class SummaryXMLAnalyzer : EditorWindow
    {
        #region Fields

        [SerializeField] private string engineXMLFilePath;
        [SerializeField] private string editorXMLFilePath;
        [SerializeField] private UIEControlsNameSO controlsNameSO;
        [SerializeField] private UIEControlsSummarySO controlsSummarySO;

        #endregion

        [MenuItem("Window/UI Toolkit/UIEEx/Code Gen/SummaryXML Analyzer")]
        private static void ShowWindow()
        {
            var window = GetWindow<SummaryXMLAnalyzer>();
            window.titleContent = new GUIContent("SummaryXML Analyzer");
            window.Show();
        }

        private void OnGUI()
        {
            controlsNameSO = (UIEControlsNameSO)EditorGUILayout.ObjectField
                ("Controls Name SO", controlsNameSO, typeof(UIEControlsNameSO), false);
            controlsSummarySO = (UIEControlsSummarySO)EditorGUILayout.ObjectField
                ("Controls Summary SO", controlsSummarySO, typeof(UIEControlsSummarySO), false);

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

            if (GUILayout.Button("Analyze"))
                Analyze();
            if (GUILayout.Button("Write Summary"))
                WriteSummary();
        }

        #region Analye

        private void Analyze()
        {
            string[] engineControlsName = controlsNameSO.EngineControlsNames;
            string[] editorControlsName = controlsNameSO.EditorControlsNames;

            string[] xmlEngineFileLines = System.IO.File.ReadAllLines(engineXMLFilePath);
            string[] xmlEditorFileLines = System.IO.File.ReadAllLines(editorXMLFilePath);
            
            LogAnalyzeResult(engineControlsName, xmlEngineFileLines);
            LogAnalyzeResult(editorControlsName, xmlEditorFileLines);
        }

        private void LogAnalyzeResult(string[] controlNames, string[] xmlLines)
        {
            foreach (string controlName in controlNames)
            {
                int[] indices = GetConstructorLineIndex(xmlLines, controlName);
                if (indices.Length == 0)
                    Debug.LogError($"Not find {controlName}");
                else
                {
                    string log = "";
                    log += $"Find {indices.Length} {controlName}\n";
                    foreach (int index in indices)
                    {
                        log += $"line{index}: {xmlLines[index]}\n";
                    }

                    Debug.Log(log);
                }
            }
        }


        
        #endregion

        #region Write Summary

        private void WriteSummary()
        {
            string[] engineControlsName = controlsNameSO.EngineControlsNames;
            string[] editorControlsName = controlsNameSO.EditorControlsNames;

            string[] xmlEngineFileLines = System.IO.File.ReadAllLines(engineXMLFilePath);
            string[] xmlEditorFileLines = System.IO.File.ReadAllLines(editorXMLFilePath);

            NameSummaryPair[]
                enginePairs = GetSummaryPairs(engineControlsName, xmlEngineFileLines);
            NameSummaryPair[]
                editorPairs = GetSummaryPairs(editorControlsName, xmlEditorFileLines);

            controlsSummarySO.EngineControlsSummary = enginePairs;
            controlsSummarySO.EditorControlsSummary = editorPairs;
            
            EditorUtility.SetDirty(controlsSummarySO);
        }

        private NameSummaryPair[] GetSummaryPairs(string[] names, string[] xmlLines)
        {
            List<NameSummaryPair> pairs = new List<NameSummaryPair>();

            foreach (string controlName in names)
            {
                int[] indices = GetConstructorLineIndex(xmlLines, controlName);
                string[] summaries = indices.Select(i => ScrapeSummary(xmlLines, i)).ToArray();
                string fallback = ScrapeSummary(xmlLines, GetTypeLineIndex(xmlLines, controlName));

                pairs.Add
                    (new NameSummaryPair()
                        {Name = controlName, Summary = new SummaryContent(){CtorSummaries = summaries, TypeSummary = fallback}});
            }

            return pairs.ToArray();
        }

        private string ScrapeSummary(string[] xmlLines, int index)
        {
            string result = "";
            int offset = 1;
            
            while (!RemoveStartSpace(xmlLines[index + offset]).StartsWith("</member>"))
            {
                if (offset > 20)
                {
                    Debug.LogWarning($"Can not find end summary text off {xmlLines[index]} at {index} after 20 lines");
                    offset = -1;
                    break;
                }

                result += xmlLines[index + offset] + '\n';
                offset++;
            }

            result = FormatSummary(result);

            if (offset > 0)
            {
                if (result[^1] == '\n') 
                    result = result.Remove(result.Length - 1);
                return result;
            }
            return String.Empty;
        }


        #endregion


        #region Utility

        private int GetTypeLineIndex(string[] xmlLines, string typeFullName)
        {
            return Array.FindIndex(xmlLines, line => line.Contains($"<member name=\"T:{typeFullName}\">"));
        }

        private int[] GetConstructorLineIndex(string[] xmlLines, string typeFullName = null)
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

                if (indices.Length == 0)
                {
                    Debug.LogWarning($"Find no constructor xml for {typeFullName} trying callback summary");
                    indices = Enumerable.Range(0, xmlLines.Length)
                        .Where(i =>
                            xmlLines[i].Contains($"T:{typeFullName}"))
                        .ToArray();
                }
            }


            return indices;
        }
        
        private string RemoveStartSpace(string input)
        {
            int startIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }

            return input.Substring(startIndex);
        }

        private string FormatSummary(string xmlText)
        {
            string result = "";

            string[] xmlLines = xmlText.Split("\n");

            foreach (string line in xmlLines)
            {
                string content = RemoveStartSpace(line);
                if (content.Length > 0)
                    result += "///" + content + '\n';
            }

            if (result[^1] == '\n')
            {
                int lastN = result.LastIndexOf('\n');
                result = result.Remove(lastN, result.Length - lastN);
            }

            return result;
        }

        #endregion
    }
}