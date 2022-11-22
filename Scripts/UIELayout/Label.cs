using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Label Label(VisualElement parent = null)
        {
            return Label(null, parent);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">string</param>
        /// <returns></returns>
        public static Label Label(string text, VisualElement parent = null)
        {
            Label label = new Label(text);
            label.SetParent(parent);
            return label;
        }
    }
}