using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="defalutText"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">string</param>
        /// <returns></returns>
        public static TextField TextField(string label, string defalutText = null, VisualElement parent = null, string bindingPath = default)
        {
            TextField textField = TextField(defalutText, parent, bindingPath);

            textField.label = label;
            
            return textField;
        }

        public static TextField TextField(string defalutText = null, VisualElement parent = null, string bindingPath = default)
        {
            TextField textField = new TextField();
            
            if (defalutText != null) textField.value = defalutText;
            
            textField.SetParent(parent);
            textField.SetBindingPath(bindingPath);

            return textField;
        }
    }
}