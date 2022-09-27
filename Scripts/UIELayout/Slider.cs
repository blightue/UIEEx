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
        /// <param name="bindingPath">float</param>
        /// <returns></returns>
        public static Slider Slider(string text, float lowValue, float highValue, VisualElement parent = null,
            string bindingPath = default)
        {
            Slider slider = Slider(lowValue, highValue, parent, bindingPath);

            slider.label = text;

            return slider;
        }

        public static Slider Slider(float lowValue, float highValue, VisualElement parent = null,
            string bindingPath = default)
        {
            Slider slider = new Slider();

            slider.lowValue = lowValue;
            slider.highValue = highValue;

            slider.SetParent(parent);
            slider.SetBindingPath(bindingPath);

            return slider;
        }
    }
}