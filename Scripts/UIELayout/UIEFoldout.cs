using UnityEngine.UIElements;
using System;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static Foldout Foldout(params VisualElement[] contents)
        {
            return Foldout(null, contents);
        }
        
        public static Foldout Foldout(string text, params VisualElement[] contents)
        {
            Foldout foldout = new Foldout();
            if(text != null) foldout.text = text;

            foreach (VisualElement content in contents)
            {
                foldout.contentContainer.Add(content);
            }
            
            return foldout;
        }

        public static Foldout SetParent(this Foldout foldout, VisualElement parent)
        {
            parent.Add(foldout);
            return foldout;
        }
    }
}