using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Slider Slider(string text, float lowValue, float highValue, VisualElement parent = null)
        {
            Slider slider = new Slider();
            
            slider.lowValue = lowValue;
            slider.highValue = highValue;

            slider.SetParent(parent);

            return slider;
        }
    }
}