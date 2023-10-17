/*
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
        /// <summary>
        /// <para>
        /// Constructs a Button.
        /// </para>
        /// </summary>
        /// <param name="text">The text of this button content</param>
        /// <param name="parent">The parent of this element.</param>
        public static Button Button (string text, VisualElement parent = null)
        {{
            Button button = new Button();
            button.text = text;
            button.SetParent(parent);
            return button;
        }}

        /// <summary>
        /// <para>
        /// Constructs a button with an Action that is triggered when the button is clicked.
        /// </para>
        /// </summary>
        /// <param name="text">The text of this button content</param>
        /// <param name="clickEvent">The action triggered when the button is clicked.</param>
        /// <param name="parent">The parent of this element.</param>
        public static Button Button (string text, System.Action clickEvent, VisualElement parent = null)
        {{
            Button button = new Button(clickEvent);
            button.text = text;
            button.SetParent(parent);
            return button;
        }}

    }
}