using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static PopupWindow PopupWindow(VisualElement parent = null)
        {
            PopupWindow popupWindow = new PopupWindow();

            popupWindow.SetParent(parent);
            
            return popupWindow;
        }
    }
}