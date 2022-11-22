using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Button Button(string text, Action clickEvent, VisualElement parent = null)
        {
            Button button = new Button(clickEvent);

            button.SetParent(parent);
            button.text = text;
            button.focusable = false;
            button.style.flexGrow = new StyleFloat(1f);

            

            return button;
        }
    }
}