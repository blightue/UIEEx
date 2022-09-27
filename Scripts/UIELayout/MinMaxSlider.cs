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
        /// <param name="parent"></param>
        /// <param name="bindingPath">UnityEngine.Vector2</param>
        /// <returns></returns>
        public static MinMaxSlider MinMaxSlider(string text, VisualElement parent = null, string bindingPath = default)
        {
            MinMaxSlider slider = MinMaxSlider(parent, bindingPath);

            slider.label = text;

            return slider;
        }
        
        public static MinMaxSlider MinMaxSlider(VisualElement parent = null, string bindingPath = default)
        {
            MinMaxSlider slider = new MinMaxSlider();

            slider.SetBindingPath(bindingPath);

            return slider;
        }
    }
}