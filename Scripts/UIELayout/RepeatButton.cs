using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static RepeatButton RepeatButton (VisualElement parent = null)
        {
            RepeatButton repeatButton = new RepeatButton();
            repeatButton.SetParent(parent);
            return repeatButton;
        }

        public static RepeatButton RepeatButton (System.Action clickEvent, System.Int64 delay, System.Int64 interval, VisualElement parent = null)
        {
            RepeatButton repeatButton = new RepeatButton(clickEvent, delay, interval);
            repeatButton.SetParent(parent);
            return repeatButton;
        }

    }
}