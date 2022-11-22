using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">string</param>
        /// <returns></returns>
        public static TextElement TextElement(string text, VisualElement parent = null)
        {
            TextElement textElement = new TextElement();

            textElement.text = text;

            textElement.SetParent(parent);

            return textElement;
        }
    }
}