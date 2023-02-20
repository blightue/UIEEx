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

using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
///<summary>
///<para>
///Constructor of the field.
///</para>
///</summary>
///<param name="defaultMask">The mask to use for a first selection.</param>
///<param name="parent">The parent of this element.</param>
        public static LayerMaskField LayerMaskField (System.Int32 defaultMask, VisualElement parent = null)
        {{
            LayerMaskField layerMaskField = new LayerMaskField(defaultMask);
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }}

///<summary>
///<para>
///Constructor of the field.
///</para>
///</summary>
///<param name="label">The label to prefix the &lt;see cref="LayerMaskField" /&gt;.</param>
///<param name="defaultMask">The mask to use for a first selection.</param>
///<param name="parent">The parent of this element.</param>
        public static LayerMaskField LayerMaskField (System.String label, System.Int32 defaultMask, VisualElement parent = null)
        {{
            LayerMaskField layerMaskField = new LayerMaskField(label, defaultMask);
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }}

///<summary>
///<para>
///Constructor of the field.
///</para>
///</summary>
///<param name="parent">The parent of this element.</param>
        public static LayerMaskField LayerMaskField (VisualElement parent = null)
        {{
            LayerMaskField layerMaskField = new LayerMaskField();
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }}

///<summary>
///<para>
///Constructor of the field.
///</para>
///</summary>
///<param name="label">The label to prefix the &lt;see cref="LayerMaskField" /&gt;.</param>
///<param name="parent">The parent of this element.</param>
        public static LayerMaskField LayerMaskField (System.String label, VisualElement parent = null)
        {{
            LayerMaskField layerMaskField = new LayerMaskField(label);
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }}

    }
}