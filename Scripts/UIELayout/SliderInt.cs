using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static SliderInt SliderInt (VisualElement parent = null)
        {
            SliderInt sliderInt = new SliderInt();
            sliderInt.SetParent(parent);
            return sliderInt;
        }

        public static SliderInt SliderInt (System.Int32 start, System.Int32 end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize, VisualElement parent = null)
        {
            SliderInt sliderInt = new SliderInt(start, end, direction, pageSize);
            sliderInt.SetParent(parent);
            return sliderInt;
        }

        public static SliderInt SliderInt (System.String label, System.Int32 start, System.Int32 end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize, VisualElement parent = null)
        {
            SliderInt sliderInt = new SliderInt(label, start, end, direction, pageSize);
            sliderInt.SetParent(parent);
            return sliderInt;
        }

    }
}