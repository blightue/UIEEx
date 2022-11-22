using UnityEngine.UIElements;
using System.Collections.Generic;

namespace SuiSuiShou.UIEEx
{
    public static class UIEExtension
    {
        public static T SetParent<T>(this T target, VisualElement parent) where T : VisualElement
        {
            if(parent != null) parent.Add(target);
            return target;
        }

        public static T SetBindingPath<T>(this T target, string bindingPath) where T : BindableElement
        {
            if (bindingPath != default)
            {
                target.bindingPath = bindingPath;
            }

            return target;
        }
    }
}