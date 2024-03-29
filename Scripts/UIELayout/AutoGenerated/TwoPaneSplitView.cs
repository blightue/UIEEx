﻿/*
This script is auto generated by UIELayoutCodeGenWindow

Copyright 2023 SUISUISHOU(blightue@gmail.com)

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
///<summary>
///<para>
///Parameterized constructor.
///</para>
///</summary>
///<param name="fixedPaneIndex">0 for setting first child as the fixed pane, 1 for the second child element.</param>
///<param name="fixedPaneStartDimension">Set an inital width or height for the fixed pane.</param>
///<param name="orientation">Orientation of the split view.</param>
///<param name="parent">The parent of this element.</param>
        public static TwoPaneSplitView TwoPaneSplitView (VisualElement parent = null)
        {{
            TwoPaneSplitView twoPaneSplitView = new TwoPaneSplitView();
            twoPaneSplitView.SetParent(parent);
            return twoPaneSplitView;
        }}

///<summary>
///<para>
///A SplitView that contains two resizable panes. One pane is fixed-size while the other pane has flex-grow style set to 1 to take all remaining space. The border between he panes is draggable to resize both panes. Both horizontal and vertical modes are supported. Requires _exactly_ two child elements to operate.
///</para>
///</summary>
///<param name="parent">The parent of this element.</param>
        public static TwoPaneSplitView TwoPaneSplitView (System.Int32 fixedPaneIndex, System.Single fixedPaneStartDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation, VisualElement parent = null)
        {{
            TwoPaneSplitView twoPaneSplitView = new TwoPaneSplitView(fixedPaneIndex, fixedPaneStartDimension, orientation);
            twoPaneSplitView.SetParent(parent);
            return twoPaneSplitView;
        }}

    }
}