using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        // public static TextField TextField(int maxLength, bool multiline, bool isPasswordField,
        //     char maskChar, VisualElement parent = null)
        // {
        //     return UIELayout.TextField(null, maxLength, multiline, isPasswordField, maskChar, parent);
        // }
        //
        //
        //
        // public static TextField TextField
        // (string label, int maxLength = -1, bool multiline = false, bool isPasswordField = false,
        //     char maskChar = default, VisualElement parent = null)
        // {
        //     TextField textField =
        //         new TextField(label, maxLength, multiline, isPasswordField, maskChar);
        //
        //     textField.labelElement.style.minWidth = new StyleLength(100);
        //     textField.labelElement.style.flexGrow = new StyleFloat(0.5f);
        //     textField.labelElement.style.flexShrink = new StyleFloat(0.5f);
        //
        //     if (parent != null) parent.Add(textField);
        //
        //     return textField;
        // }


        public static TextField TextField(VisualElement parent = null)
        {
            TextField textField = new TextField();
            if (parent != null) parent.Add(textField);
            return textField;
        }

        public static TextField TextField(string label, string defalutText = null, VisualElement parent = null)
        {
            TextField textField = new TextField(label);
            if (defalutText != null) textField.value = defalutText;
            if (parent != null) parent.Add(textField);

            //textField.labelElement.style.minWidth = new StyleLength(105);
            
            return textField;
        }
    }
}