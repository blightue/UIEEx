using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarMenu ToolbarMenu (VisualElement parent = null)
        {
            ToolbarMenu toolbarMenu = new ToolbarMenu();
            toolbarMenu.SetParent(parent);
            return toolbarMenu;
        }

    }
}