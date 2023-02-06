using System;
using UnityEngine.UIElements;
using System.Collections.Generic;

namespace SuiSuiShou.UIEEx
{
    /// <summary>
    /// UI Elements extension methods
    /// </summary>
    public static class UIEExtension
    {
        /// <summary>
        /// Set the parent of the target element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static T SetParent<T>(this T target, VisualElement parent) where T : VisualElement
        {
            if(parent != null) parent.Add(target);
            return target;
        }

        /// <summary>
        /// Set the binding path of the target element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="bindingPath"></param>
        /// <returns></returns>
        public static T SetBindingPath<T>(this T target, string bindingPath) where T : IBindable
        {
            if (bindingPath != default)
                target.bindingPath = bindingPath;
            return target;
        }


        
        /// <summary>
        /// Set the text of the target element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="text"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T SetText<T>(this T target, string text) where T : TextElement
        {
            target.text = text;
            return target;
        }
        
        /// <summary>
        /// Set the Label content of the target element, return BaseField<see cref="T"/>
        /// </summary>
        /// <param name="target"></param>
        /// <param name="label"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static BaseField<T> SetLabel<T>(this BaseField<T> target, string label)
        {
            target.label = label;
            return target;
        }
        
        /// <summary>
        /// Set the Label content of BaseField<see cref="V"/> element, return the target element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="label"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns></returns>
        public static T SetLabel<T, V>(this T target, string label) where T : BaseField<V>
        {
            target.label = label;
            return target;
        }
    }
}