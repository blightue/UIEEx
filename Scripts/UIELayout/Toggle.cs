using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parent">bool</param>
        /// <returns></returns>
        public static Toggle Toggle(string text, VisualElement parent = null)
        {
            Toggle toggle = Toggle(parent);

            toggle.text = text;

            return toggle;
        }

        public static Toggle Toggle(VisualElement parent = null)
        {
            Toggle toggle = new Toggle();

            toggle.SetParent(parent);

            return toggle;
        }
    }
}