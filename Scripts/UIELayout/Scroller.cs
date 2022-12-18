using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Scroller Scroller (VisualElement parent = null)
        {
            Scroller scroller = new Scroller();
            scroller.SetParent(parent);
            return scroller;
        }

        public static Scroller Scroller (System.Single lowValue, System.Single highValue, System.Action<System.Single> valueChanged, UnityEngine.UIElements.SliderDirection direction, VisualElement parent = null)
        {
            Scroller scroller = new Scroller(lowValue, highValue, valueChanged, direction);
            scroller.SetParent(parent);
            return scroller;
        }

    }
}