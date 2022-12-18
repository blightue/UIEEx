using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static RectField RectField (VisualElement parent = null)
        {
            RectField rectField = new RectField();
            rectField.SetParent(parent);
            return rectField;
        }

        public static RectField RectField (System.String label, VisualElement parent = null)
        {
            RectField rectField = new RectField(label);
            rectField.SetParent(parent);
            return rectField;
        }

    }
}