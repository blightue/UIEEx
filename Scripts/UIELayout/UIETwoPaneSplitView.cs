using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static TwoPaneSplitView TwoPaneSplitView(VisualElement parent = null)
        {
            TwoPaneSplitView toggle = TwoPaneSplitView(0, 200, TwoPaneSplitViewOrientation.Horizontal, parent);

            return toggle;
        }

        public static TwoPaneSplitView TwoPaneSplitView(int fixedPaneIndex, float fixedPaneStartDimension,
            TwoPaneSplitViewOrientation orientation, VisualElement parent = null)
        {
            TwoPaneSplitView twoPaneSplitView = new TwoPaneSplitView(fixedPaneIndex, fixedPaneStartDimension, orientation);

            twoPaneSplitView.SetParent(parent);

            return twoPaneSplitView;
        }
    }
}