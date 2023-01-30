using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace SuiSuiShou.UIEEx.CodeGenerator
{
    [CreateAssetMenu(menuName = "UI Toolkit/UIEEx/Code Gen/Controls Summary")]
    public class UIEControlsSummarySO : ScriptableObject
    {
        public NameSummaryPair[] EngineControlsSummary;
        public NameSummaryPair[] EditorControlsSummary;

        private Dictionary<string, SummaryContent> _engineControlsMap;
        private Dictionary<string, SummaryContent> _editorControlsMap;

        public Dictionary<string, SummaryContent> EngineControlsMap => _engineControlsMap ??= Pairs2Map(EngineControlsSummary);
        public Dictionary<string, SummaryContent> EditorControlsMap => _editorControlsMap ??= Pairs2Map(EditorControlsSummary);

        private Dictionary<string, SummaryContent> Pairs2Map(NameSummaryPair[] pairs)
        {
            return pairs
                .ToDictionary(p => p.Name, p => p.Summary);
        }
    }
    
    [Serializable]
    public class NameSummaryPair
    {
        public string Name;
        public SummaryContent Summary;
    }

    [Serializable]
    public class SummaryContent
    {
        public string TypeSummary;
        [FormerlySerializedAs("CtorSummary")] public string[] CtorSummaries;
    }
}