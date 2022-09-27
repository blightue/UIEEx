using System.Collections;
using System;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public partial class UIELayout
    {
        public static ListView ListView(string text, IList itemSource, float itemHeight, Func<VisualElement> makeItem,
            Action<VisualElement, int> bindItem, VisualElement parent = null, string bindingPath = default)
        {
            ListView listView = ListView(itemSource, itemHeight, makeItem, bindItem, parent, bindingPath);

            listView.headerTitle = text;

            return listView;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemSource"></param>
        /// <param name="itemHeight"></param>
        /// <param name="makeItem"></param>
        /// <param name="bindItem"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">IList</param>
        /// <returns></returns>
        public static ListView ListView(IList itemSource, float itemHeight, Func<VisualElement> makeItem,
            Action<VisualElement, int> bindItem, VisualElement parent = null, string bindingPath = default)
        {
            ListView listView = new ListView(itemSource, itemHeight, makeItem, bindItem);

            listView.SetParent(parent);
            listView.SetBindingPath(bindingPath);

            return listView;
        }
    }
}