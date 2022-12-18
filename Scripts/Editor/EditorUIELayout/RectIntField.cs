using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static RectIntField RectIntField (VisualElement parent = null)
        {
            RectIntField rectIntField = new RectIntField();
            rectIntField.SetParent(parent);
            return rectIntField;
        }

        public static RectIntField RectIntField (System.String label, VisualElement parent = null)
        {
            RectIntField rectIntField = new RectIntField(label);
            rectIntField.SetParent(parent);
            return rectIntField;
        }

    }
}