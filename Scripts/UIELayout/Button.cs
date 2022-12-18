using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Button Button (VisualElement parent = null)
        {
            Button button = new Button();
            button.SetParent(parent);
            return button;
        }

        public static Button Button (System.Action clickEvent, VisualElement parent = null)
        {
            Button button = new Button(clickEvent);
            button.SetParent(parent);
            return button;
        }

    }
}