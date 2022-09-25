using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static TextElement TextElement(string text, VisualElement parent = null)
        {
            TextElement textElement = new TextElement();

            textElement.text = text;

            textElement.SetParent(parent);

            return textElement;
        }
    }
}