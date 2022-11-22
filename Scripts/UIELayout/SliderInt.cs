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
        /// <param name="lowValue"></param>
        /// <param name="highValue"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">int</param>
        /// <returns></returns>
        public static SliderInt SliderInt(string text, int lowValue, int highValue, VisualElement parent = null)
        {
            SliderInt sliderInt = SliderInt(lowValue, highValue, parent);

            sliderInt.label = text;

            return sliderInt;
        }
        
        public static SliderInt SliderInt(int lowValue, int highValue, VisualElement parent = null)
        {
            SliderInt sliderInt = new SliderInt();
            
            sliderInt.lowValue = lowValue;
            sliderInt.highValue = highValue;

            sliderInt.SetParent(parent);

            return sliderInt;
        }
    }
}