using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Scroller Scroller(float lowValue, float highValue, SliderDirection direction, VisualElement parent = null)
        {
            Scroller scroller = new Scroller();
            
            scroller.direction = direction;
            scroller.lowValue = lowValue;
            scroller.highValue = highValue;

            scroller.style.flexGrow = 1f;
            scroller.style.flexShrink = 1f;

            scroller.SetParent(parent);

            return scroller;
        }
    }
}