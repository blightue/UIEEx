using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static MinMaxSlider MinMaxSlider (VisualElement parent = null)
        {
            MinMaxSlider minMaxSlider = new MinMaxSlider();
            minMaxSlider.SetParent(parent);
            return minMaxSlider;
        }

        public static MinMaxSlider MinMaxSlider (System.Single minValue, System.Single maxValue, System.Single minLimit, System.Single maxLimit, VisualElement parent = null)
        {
            MinMaxSlider minMaxSlider = new MinMaxSlider(minValue, maxValue, minLimit, maxLimit);
            minMaxSlider.SetParent(parent);
            return minMaxSlider;
        }

        public static MinMaxSlider MinMaxSlider (System.String label, System.Single minValue, System.Single maxValue, System.Single minLimit, System.Single maxLimit, VisualElement parent = null)
        {
            MinMaxSlider minMaxSlider = new MinMaxSlider(label, minValue, maxValue, minLimit, maxLimit);
            minMaxSlider.SetParent(parent);
            return minMaxSlider;
        }

    }
}