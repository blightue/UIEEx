using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static TwoPaneSplitView TwoPaneSplitView (VisualElement parent = null)
        {
            TwoPaneSplitView twoPaneSplitView = new TwoPaneSplitView();
            twoPaneSplitView.SetParent(parent);
            return twoPaneSplitView;
        }

        public static TwoPaneSplitView TwoPaneSplitView (System.Int32 fixedPaneIndex, System.Single fixedPaneStartDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation, VisualElement parent = null)
        {
            TwoPaneSplitView twoPaneSplitView = new TwoPaneSplitView(fixedPaneIndex, fixedPaneStartDimension, orientation);
            twoPaneSplitView.SetParent(parent);
            return twoPaneSplitView;
        }

    }
}