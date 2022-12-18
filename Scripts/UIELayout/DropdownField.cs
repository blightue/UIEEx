using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static DropdownField DropdownField (VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField();
            dropdownField.SetParent(parent);
            return dropdownField;
        }

        public static DropdownField DropdownField (System.String label, VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField(label);
            dropdownField.SetParent(parent);
            return dropdownField;
        }

        public static DropdownField DropdownField (System.Collections.Generic.List<System.String> choices, System.String defaultValue, System.Func<System.String,System.String> formatSelectedValueCallback, System.Func<System.String,System.String> formatListItemCallback, VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField(choices, defaultValue, formatSelectedValueCallback, formatListItemCallback);
            dropdownField.SetParent(parent);
            return dropdownField;
        }

        public static DropdownField DropdownField (System.String label, System.Collections.Generic.List<System.String> choices, System.String defaultValue, System.Func<System.String,System.String> formatSelectedValueCallback, System.Func<System.String,System.String> formatListItemCallback, VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField(label, choices, defaultValue, formatSelectedValueCallback, formatListItemCallback);
            dropdownField.SetParent(parent);
            return dropdownField;
        }

        public static DropdownField DropdownField (System.Collections.Generic.List<System.String> choices, System.Int32 defaultIndex, System.Func<System.String,System.String> formatSelectedValueCallback, System.Func<System.String,System.String> formatListItemCallback, VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField(choices, defaultIndex, formatSelectedValueCallback, formatListItemCallback);
            dropdownField.SetParent(parent);
            return dropdownField;
        }

        public static DropdownField DropdownField (System.String label, System.Collections.Generic.List<System.String> choices, System.Int32 defaultIndex, System.Func<System.String,System.String> formatSelectedValueCallback, System.Func<System.String,System.String> formatListItemCallback, VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField(label, choices, defaultIndex, formatSelectedValueCallback, formatListItemCallback);
            dropdownField.SetParent(parent);
            return dropdownField;
        }

    }
}