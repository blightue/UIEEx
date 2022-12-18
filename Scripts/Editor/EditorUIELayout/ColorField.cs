using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ColorField ColorField (VisualElement parent = null)
        {
            ColorField colorField = new ColorField();
            colorField.SetParent(parent);
            return colorField;
        }

        public static ColorField ColorField (System.String label, VisualElement parent = null)
        {
            ColorField colorField = new ColorField(label);
            colorField.SetParent(parent);
            return colorField;
        }

    }
}