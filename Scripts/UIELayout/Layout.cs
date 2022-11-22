using System;
using System.Collections;
using System.Collections.Generic;
using PlasticGui.WorkspaceWindow.Diff;
using UnityEngine;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static VisualElement VerticalLayout(VisualElement parent = null)
        {
            VisualElement element = new VisualElement();
            element
                .SetParent(parent)
                .style.flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Column);

            return element;
        }

        public static VisualElement HorzontalLayout(VisualElement parent = null)
        {
            VisualElement element = new VisualElement();

            element
                .SetParent(parent)
                .style.flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Row);

            return element;
        }

        public static Box Box(VisualElement parent = null)
        {
            return UIELayout.Box(FlexDirection.Column, parent);
        }

        public static Box Box(FlexDirection direction, VisualElement parent = null)
        {
            Box box = new Box();

            box.SetParent(parent).style.flexDirection = new StyleEnum<FlexDirection>(direction);

            return box;
        }

        public static GroupBox GroupBox(string text, VisualElement parent)
        {
            GroupBox groupBox = new GroupBox();

            groupBox.SetParent(parent).text = text;

            return groupBox;
        }
    }
}