using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static RepeatButton RepeatButton(string text, Action clickEvent, VisualElement parent = null)
        {
            RepeatButton repeatButton = new RepeatButton();

            repeatButton.text = text;
            repeatButton.focusable = false;
            repeatButton.style.flexGrow = new StyleFloat(1f);
            repeatButton.SetAction(clickEvent, 0,1);

            repeatButton.SetParent(parent);

            return repeatButton;
        }
    }
}