using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "UIEEx/Code Gen/Elements")]
public class UIEControlsNameSO : ScriptableObject
{
    [SerializeField] public string[] EngineControlsNames;
    [SerializeField] public string[] EditorControlsNames;

    private ControlElement[] _engineControls;
    private ControlElement[] _editorControls;

    public ControlElement[] EngineElements => GetEngineElements(EngineControlsNames);
    public ControlElement[] EditorElements => GetEditorElements(EditorControlsNames);

    private ControlElement[] GetEngineElements(string[] typeNames)
    {
        Assembly engineAssembly = Assembly.Load("UnityEngine.UIElementsModule");
        ControlElement[] result = new ControlElement[typeNames.Length];
        for (int i = 0; i < typeNames.Length; i++)
        {
            result[i] = new ControlElement
            (
                engineAssembly.GetType(typeNames[i], true, true),
                "UIELayout",
                "SuiSuiShou.UIEEx",
                false
            );
        }

        return result;
    }

    private ControlElement[] GetEditorElements(string[] typeNames)
    {
        Assembly editorAssembly = Assembly.Load("UnityEditor.UIElementsModule");
        ControlElement[] result = new ControlElement[typeNames.Length];
        for (int i = 0; i < typeNames.Length; i++)
        {
            result[i] = new ControlElement
            (
                editorAssembly.GetType(typeNames[i], true, true),
                "EditorUIELayout",
                "SuiSuiShou.UIEEx.Editor",
                true
            );
        }

        return result;
    }
}

[Serializable]
public class ControlElement
{
    public Type Type;
    public string ClassName;
    public string NameSpace;
    public bool IsEditor;

    public ControlElement(Type type, string className, string nameSpace, bool isEditor)
    {
        Type = type;
        ClassName = className;
        NameSpace = nameSpace;
        IsEditor = isEditor;
    }
}