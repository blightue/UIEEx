using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarButton ToolbarButton (System.Action clickEvent, VisualElement parent = null)
        {
            ToolbarButton toolbarButton = new ToolbarButton(clickEvent);
            toolbarButton.SetParent(parent);
            return toolbarButton;
        }

        public static ToolbarButton ToolbarButton (VisualElement parent = null)
        {
            ToolbarButton toolbarButton = new ToolbarButton();
            toolbarButton.SetParent(parent);
            return toolbarButton;
        }

    }
}