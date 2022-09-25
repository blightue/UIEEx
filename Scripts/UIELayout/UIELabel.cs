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
        
        public static Label Label(string text, VisualElement parent = null)
        {
            Label label = new Label(text);
            SetParent(parent, label);
            return label;
        }
    }
}