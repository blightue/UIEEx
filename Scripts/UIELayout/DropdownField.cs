using UnityEngine.UIElements;
using System;
using System.Linq;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        
        public static DropdownField DropdownField(string text, Type enumType, int defaultIndex, VisualElement parent = null)
        {
            return DropdownField(text, Enum.GetNames(enumType), defaultIndex, parent);
        }
        public static DropdownField DropdownField(string text, string[] choices, int defaultIndex, VisualElement parent = null)
        {
            DropdownField dropdownField = new DropdownField();

            dropdownField.label = text;
            dropdownField.choices = choices.ToList();
            dropdownField.index = -1;
            dropdownField.SetParent(parent);
            
            return dropdownField;
        }
    }
}