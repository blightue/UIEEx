using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Label Label(VisualElement parent = null, string bindingPath = default)
        {
            return Label(null, parent, bindingPath);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">string</param>
        /// <returns></returns>
        public static Label Label(string text, VisualElement parent = null, string bindingPath = default)
        {
            Label label = new Label(text);
            label.SetParent(parent);
            label.SetBindingPath(bindingPath);
            return label;
        }
    }
}