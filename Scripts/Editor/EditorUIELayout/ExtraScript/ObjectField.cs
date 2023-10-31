/*
This script is used for adding extra-ctor for EditorUIElayout

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

using System;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout
    {
        /// <summary>
        /// <para>
        /// Constructor.
        /// </para>
        /// </summary>
        /// <param name="label">The label of this field</param>
        /// <param name="objType">The object type of the binding content</param>
        /// <param name="parent">The parent of this element.</param>
        public static ObjectField ObjectField(System.String label, Type objType, VisualElement parent = null)
        {
            {
                ObjectField objectField = new ObjectField(label);
                objectField.objectType = objType;
                objectField.SetParent(parent);
                return objectField;
            }
        }

        /// <summary>
        /// <para>
        /// Constructor.
        /// </para>
        /// </summary>
        /// <param name="label">The label of this field</param>
        /// <param name="objectType">The object type of the binding content</param>
        /// <param name="allowSceneObjects">Allows scene objects to be assigned to the field</param>
        /// <param name="parent">The parent of this element.</param>
        public static ObjectField ObjectField(System.String label, Type objectType, bool allowSceneObjects, VisualElement parent = null)
        {
            {
                ObjectField objectField = new ObjectField(label);
                objectField.objectType = objectType;
                objectField.allowSceneObjects = allowSceneObjects;
                objectField.SetParent(parent);
                return objectField;
            }
        }

    }
}