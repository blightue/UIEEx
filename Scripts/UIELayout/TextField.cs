using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static TextField TextField (VisualElement parent = null)
        {
            TextField textField = new TextField();
            textField.SetParent(parent);
            return textField;
        }

        public static TextField TextField (System.Int32 maxLength, System.Boolean multiline, System.Boolean isPasswordField, System.Char maskChar, VisualElement parent = null)
        {
            TextField textField = new TextField(maxLength, multiline, isPasswordField, maskChar);
            textField.SetParent(parent);
            return textField;
        }

        public static TextField TextField (System.String label, VisualElement parent = null)
        {
            TextField textField = new TextField(label);
            textField.SetParent(parent);
            return textField;
        }

        public static TextField TextField (System.String label, System.Int32 maxLength, System.Boolean multiline, System.Boolean isPasswordField, System.Char maskChar, VisualElement parent = null)
        {
            TextField textField = new TextField(label, maxLength, multiline, isPasswordField, maskChar);
            textField.SetParent(parent);
            return textField;
        }

    }
}