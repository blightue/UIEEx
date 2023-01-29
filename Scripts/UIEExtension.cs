using System;
using UnityEngine.UIElements;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;

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

        public static T SetBindObject<T>(this T target, SerializedObject serializedObj) where T : BindableElement
        {
            target.Bind(serializedObj);
            return target;
        }
        
        public static T SetText<T>(this T target, string text) where T : TextElement
        {
            target.text = text;
            return target;
        }
        
        public static BaseField<T> SetLabel<T>(this BaseField<T> target, string label)
        {
            target.label = label;
            return target;
        }
    }
}