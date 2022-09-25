using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        
        public static VisualElement VerticalLayout(params VisualElement[] children)
        {
            VisualElement element = new VisualElement();

            element.style.flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Column);

            foreach (var item in children)
            {
                element.Add(item);
            }
            
            return element;
        }
        
        public static VisualElement HorzontalLayout(params VisualElement[] children)
        {
            VisualElement element = new VisualElement();

            element.style.flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Row);

            foreach (var item in children)
            {
                element.Add(item);
            }
            
            return element;
        }

        public static Box Box(params VisualElement[] children)
        {
            return UIELayout.Box(FlexDirection.Column, children);
        }

        public static Box Box(FlexDirection direction, params VisualElement[] children)
        {
            Box box = new Box();

            box.style.flexDirection = new StyleEnum<FlexDirection>(direction);

            foreach (VisualElement element in children)
            {
                box.Add(element);
            }

            return box;
        }

        public static GroupBox GroupBox(string text, params VisualElement[] children)
        {
            GroupBox groupBox = new GroupBox();

            groupBox.text = text;

            foreach (VisualElement element in children)
            {
                groupBox.Add(element);
            }

            return groupBox;
        }

        public static void SetParent(VisualElement parent, VisualElement child)
        {
            if(parent != null) parent.Add(child);
        }
    }
}