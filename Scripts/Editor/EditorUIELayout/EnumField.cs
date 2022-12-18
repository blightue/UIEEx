using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static EnumField EnumField (VisualElement parent = null)
        {
            EnumField enumField = new EnumField();
            enumField.SetParent(parent);
            return enumField;
        }

        public static EnumField EnumField (System.Enum defaultValue, VisualElement parent = null)
        {
            EnumField enumField = new EnumField(defaultValue);
            enumField.SetParent(parent);
            return enumField;
        }

        public static EnumField EnumField (System.String label, System.Enum defaultValue, VisualElement parent = null)
        {
            EnumField enumField = new EnumField(label, defaultValue);
            enumField.SetParent(parent);
            return enumField;
        }

    }
}