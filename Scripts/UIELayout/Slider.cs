using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Slider Slider (VisualElement parent = null)
        {
            Slider slider = new Slider();
            slider.SetParent(parent);
            return slider;
        }

        public static Slider Slider (System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize, VisualElement parent = null)
        {
            Slider slider = new Slider(start, end, direction, pageSize);
            slider.SetParent(parent);
            return slider;
        }

        public static Slider Slider (System.String label, System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize, VisualElement parent = null)
        {
            Slider slider = new Slider(label, start, end, direction, pageSize);
            slider.SetParent(parent);
            return slider;
        }

    }
}