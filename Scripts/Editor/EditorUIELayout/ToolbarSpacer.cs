using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarSpacer ToolbarSpacer (VisualElement parent = null)
        {
            ToolbarSpacer toolbarSpacer = new ToolbarSpacer();
            toolbarSpacer.SetParent(parent);
            return toolbarSpacer;
        }

    }
}