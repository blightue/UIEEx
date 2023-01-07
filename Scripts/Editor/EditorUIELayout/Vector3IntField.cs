﻿/*
This script is auto generated by UIELayoutCodeGenWindow

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
        public static Vector3IntField Vector3IntField (VisualElement parent = null)
        {
            Vector3IntField vector3IntField = new Vector3IntField();
            vector3IntField.SetParent(parent);
            return vector3IntField;
        }

        public static Vector3IntField Vector3IntField (System.String label, VisualElement parent = null)
        {
            Vector3IntField vector3IntField = new Vector3IntField(label);
            vector3IntField.SetParent(parent);
            return vector3IntField;
        }

    }
}