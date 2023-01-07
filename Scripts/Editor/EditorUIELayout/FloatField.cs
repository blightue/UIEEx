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
        public static FloatField FloatField (VisualElement parent = null)
        {
            FloatField floatField = new FloatField();
            floatField.SetParent(parent);
            return floatField;
        }

        public static FloatField FloatField (System.Int32 maxLength, VisualElement parent = null)
        {
            FloatField floatField = new FloatField(maxLength);
            floatField.SetParent(parent);
            return floatField;
        }

        public static FloatField FloatField (System.String label, System.Int32 maxLength, VisualElement parent = null)
        {
            FloatField floatField = new FloatField(label, maxLength);
            floatField.SetParent(parent);
            return floatField;
        }

    }
}