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
///Constructs an EnumFlagsField with a default value, and initializes its underlying type.
///</para>
///</summary>
///<param name="defaultValue">Initial value. This also detects the Enum type.</param>
///<param name="parent">The parent of this element.</param>
        public static EnumFlagsField EnumFlagsField (System.Enum defaultValue, VisualElement parent = null)
        {{
            EnumFlagsField enumFlagsField = new EnumFlagsField(defaultValue);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }}

///<summary>
///<para>
///Constructs an EnumFlagsField with a default value, and initializes its underlying type.
///</para>
///</summary>
///<param name="defaultValue">Initial value. This also detects the Enum type.</param>
///<param name="includeObsoleteValues"></param>
///<param name="parent">The parent of this element.</param>
        public static EnumFlagsField EnumFlagsField (System.Enum defaultValue, System.Boolean includeObsoleteValues, VisualElement parent = null)
        {{
            EnumFlagsField enumFlagsField = new EnumFlagsField(defaultValue, includeObsoleteValues);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }}

///<summary>
///<para>
///Constructs an EnumFlagsField with a default value, and initializes its underlying type.
///</para>
///</summary>
///<param name="defaultValue">Initial value. This also detects the Enum type.</param>
///<param name="label"></param>
///<param name="parent">The parent of this element.</param>
        public static EnumFlagsField EnumFlagsField (System.String label, System.Enum defaultValue, VisualElement parent = null)
        {{
            EnumFlagsField enumFlagsField = new EnumFlagsField(label, defaultValue);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }}

///<summary>
///<para>
///Constructs an EnumFlagsField with a default value, and initializes its underlying type.
///</para>
///</summary>
///<param name="parent">The parent of this element.</param>
        public static EnumFlagsField EnumFlagsField (VisualElement parent = null)
        {{
            EnumFlagsField enumFlagsField = new EnumFlagsField();
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }}

///<summary>
///<para>
///Constructs an EnumFlagsField with a default value, and initializes its underlying type.
///</para>
///</summary>
///<param name="defaultValue">Initial value. This also detects the Enum type.</param>
///<param name="label"></param>
///<param name="includeObsoleteValues"></param>
///<param name="parent">The parent of this element.</param>
        public static EnumFlagsField EnumFlagsField (System.String label, System.Enum defaultValue, System.Boolean includeObsoleteValues, VisualElement parent = null)
        {{
            EnumFlagsField enumFlagsField = new EnumFlagsField(label, defaultValue, includeObsoleteValues);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }}

///<summary>
///<para>
///Constructs an EnumFlagsField with a default value, and initializes its underlying type.
///</para>
///</summary>
///<param name="label"></param>
///<param name="parent">The parent of this element.</param>
        public static EnumFlagsField EnumFlagsField (System.String label, VisualElement parent = null)
        {{
            EnumFlagsField enumFlagsField = new EnumFlagsField(label);
            enumFlagsField.SetParent(parent);
            return enumFlagsField;
        }}

    }
}