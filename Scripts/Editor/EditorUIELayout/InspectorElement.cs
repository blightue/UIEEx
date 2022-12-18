using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static InspectorElement InspectorElement (VisualElement parent = null)
        {
            InspectorElement inspectorElement = new InspectorElement();
            inspectorElement.SetParent(parent);
            return inspectorElement;
        }

        public static InspectorElement InspectorElement (UnityEngine.Object obj, VisualElement parent = null)
        {
            InspectorElement inspectorElement = new InspectorElement(obj);
            inspectorElement.SetParent(parent);
            return inspectorElement;
        }

        public static InspectorElement InspectorElement (UnityEditor.SerializedObject obj, VisualElement parent = null)
        {
            InspectorElement inspectorElement = new InspectorElement(obj);
            inspectorElement.SetParent(parent);
            return inspectorElement;
        }

        public static InspectorElement InspectorElement (UnityEditor.Editor editor, VisualElement parent = null)
        {
            InspectorElement inspectorElement = new InspectorElement(editor);
            inspectorElement.SetParent(parent);
            return inspectorElement;
        }

    }
}