using System.Collections;
using System;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public partial class UIELayout
    {
        public static ListView ListView(string text, IList itemSource, float itemHeight, Func<VisualElement> makeItem,
            Action<VisualElement, int> bindItem, VisualElement parent = null)
        {
            ListView listView = ListView(itemSource, itemHeight, makeItem, bindItem);

            listView.headerTitle = text;

            return listView;
        }

        public static ListView ListView(IList itemSource, float itemHeight, Func<VisualElement> makeItem,
            Action<VisualElement, int> bindItem, VisualElement parent = null)
        {
            ListView listView = new ListView(itemSource, itemHeight, makeItem, bindItem);

            listView.SetParent(parent);

            return listView;
        }
    }
}