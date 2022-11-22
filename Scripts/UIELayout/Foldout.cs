using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Foldout Foldout(string text, VisualElement parent = null)
        {
            Foldout foldout = new Foldout();
            foldout.SetParent(parent);
            if(text != null) foldout.text = text;

            return foldout;
        }
    }
}