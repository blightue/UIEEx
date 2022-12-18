using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarBreadcrumbs ToolbarBreadcrumbs (VisualElement parent = null)
        {
            ToolbarBreadcrumbs toolbarBreadcrumbs = new ToolbarBreadcrumbs();
            toolbarBreadcrumbs.SetParent(parent);
            return toolbarBreadcrumbs;
        }

    }
}