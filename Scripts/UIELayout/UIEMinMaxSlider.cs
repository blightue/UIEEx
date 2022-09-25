using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static MinMaxSlider MinMaxSlider(VisualElement parent = null)
        {
            return MinMaxSlider(null, parent);
        }
        
        public static MinMaxSlider MinMaxSlider(string text, VisualElement parent = null)
        {
            MinMaxSlider slider = new MinMaxSlider(text);
            
            return slider;
        }
    }
}