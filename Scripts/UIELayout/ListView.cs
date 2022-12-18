using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static ListView ListView (VisualElement parent = null)
        {
            ListView listView = new ListView();
            listView.SetParent(parent);
            return listView;
        }

        public static ListView ListView (System.Collections.IList itemsSource, System.Single itemHeight, System.Func<UnityEngine.UIElements.VisualElement> makeItem, System.Action<UnityEngine.UIElements.VisualElement,System.Int32> bindItem, VisualElement parent = null)
        {
            ListView listView = new ListView(itemsSource, itemHeight, makeItem, bindItem);
            listView.SetParent(parent);
            return listView;
        }

    }
}