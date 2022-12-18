using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "UIEEx/Code Gen/Elements")]
    public class UIETypeNameSO : ScriptableObject
    {
        [FormerlySerializedAs("EngineElementNames")] [SerializeField] public string[] EngineElementTypeNames;
        [FormerlySerializedAs("EditorElementNames")] [SerializeField] public string[] EditorElementTypeNames;
        
        // public string[] EngineElementNames => engineElementNames.Select(a => "UnityEngine.UIElements." + a).ToArray();
        // public string[] EditorElementNames => editorElementNames.Select(a => "UnityEditor.UIElements." + a).ToArray();
    }
