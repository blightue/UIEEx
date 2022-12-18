using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarToggle ToolbarToggle (VisualElement parent = null)
        {
            ToolbarToggle toolbarToggle = new ToolbarToggle();
            toolbarToggle.SetParent(parent);
            return toolbarToggle;
        }

    }
}