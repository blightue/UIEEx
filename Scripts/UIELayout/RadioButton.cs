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
///Creates a RadioButton with no label.
///</para>
///</summary>
///<param name="parent">The parent of this element.</param>
        public static RadioButton RadioButton (VisualElement parent = null)
        {{
            RadioButton radioButton = new RadioButton();
            radioButton.SetParent(parent);
            return radioButton;
        }}

///<summary>
///<para>
///Creates a RadioButton with a Label and a default manipulator.
///</para>
///</summary>
///<param name="label">The Label text.</param>
///<param name="parent">The parent of this element.</param>
        public static RadioButton RadioButton (System.String label, VisualElement parent = null)
        {{
            RadioButton radioButton = new RadioButton(label);
            radioButton.SetParent(parent);
            return radioButton;
        }}

    }
}