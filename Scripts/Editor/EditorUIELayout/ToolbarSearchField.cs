using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarSearchField ToolbarSearchField (VisualElement parent = null)
        {
            ToolbarSearchField toolbarSearchField = new ToolbarSearchField();
            toolbarSearchField.SetParent(parent);
            return toolbarSearchField;
        }

    }
}