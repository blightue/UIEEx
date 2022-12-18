using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static ScrollView ScrollView (VisualElement parent = null)
        {
            ScrollView scrollView = new ScrollView();
            scrollView.SetParent(parent);
            return scrollView;
        }

        public static ScrollView ScrollView (UnityEngine.UIElements.ScrollViewMode scrollViewMode, VisualElement parent = null)
        {
            ScrollView scrollView = new ScrollView(scrollViewMode);
            scrollView.SetParent(parent);
            return scrollView;
        }

    }
}