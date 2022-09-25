using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static SliderInt SliderInt(string text, int lowValue, int highValue, VisualElement parent = null)
        {
            SliderInt sliderInt = new SliderInt();
            
            sliderInt.lowValue = lowValue;
            sliderInt.highValue = highValue;

            sliderInt.SetParent(parent);

            return sliderInt;
        }
    }
}