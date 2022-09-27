using UnityEngine.UIElements;
using System;
using System.Linq;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static HelpBox HelpBox(string text, HelpBoxMessageType msgType, VisualElement parent = null)
        {
            HelpBox helpBox = new HelpBox(text, msgType);

            helpBox.SetParent(parent);

            return helpBox;
        }

    }
}