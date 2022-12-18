using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static EnumFlagsField EnumFlagsField (System.Enum defaultValue, VisualElement parent = null)
        {
            EnumFlagsField enumFlagsField = new EnumFlagsField(defaultValue);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }

        public static EnumFlagsField EnumFlagsField (System.Enum defaultValue, System.Boolean includeObsoleteValues, VisualElement parent = null)
        {
            EnumFlagsField enumFlagsField = new EnumFlagsField(defaultValue, includeObsoleteValues);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }

        public static EnumFlagsField EnumFlagsField (System.String label, System.Enum defaultValue, VisualElement parent = null)
        {
            EnumFlagsField enumFlagsField = new EnumFlagsField(label, defaultValue);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }

        public static EnumFlagsField EnumFlagsField (VisualElement parent = null)
        {
            EnumFlagsField enumFlagsField = new EnumFlagsField();
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }

        public static EnumFlagsField EnumFlagsField (System.String label, System.Enum defaultValue, System.Boolean includeObsoleteValues, VisualElement parent = null)
        {
            EnumFlagsField enumFlagsField = new EnumFlagsField(label, defaultValue, includeObsoleteValues);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }

        public static EnumFlagsField EnumFlagsField (System.String label, VisualElement parent = null)
        {
            EnumFlagsField enumFlagsField = new EnumFlagsField(label);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }

    }
}