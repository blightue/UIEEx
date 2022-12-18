using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static MaskField MaskField (System.Collections.Generic.List<System.String> choices, System.Int32 defaultMask, System.Func<System.String,System.String> formatSelectedValueCallback, System.Func<System.String,System.String> formatListItemCallback, VisualElement parent = null)
        {
            MaskField maskField = new MaskField(choices, defaultMask, formatSelectedValueCallback, formatListItemCallback);
            maskField.SetParent(parent);
            return maskField;
        }

        public static MaskField MaskField (System.String label, System.Collections.Generic.List<System.String> choices, System.Int32 defaultMask, System.Func<System.String,System.String> formatSelectedValueCallback, System.Func<System.String,System.String> formatListItemCallback, VisualElement parent = null)
        {
            MaskField maskField = new MaskField(label, choices, defaultMask, formatSelectedValueCallback, formatListItemCallback);
            maskField.SetParent(parent);
            return maskField;
        }

        public static MaskField MaskField (VisualElement parent = null)
        {
            MaskField maskField = new MaskField();
            maskField.SetParent(parent);
            return maskField;
        }

        public static MaskField MaskField (System.String label, VisualElement parent = null)
        {
            MaskField maskField = new MaskField(label);
            maskField.SetParent(parent);
            return maskField;
        }

    }
}