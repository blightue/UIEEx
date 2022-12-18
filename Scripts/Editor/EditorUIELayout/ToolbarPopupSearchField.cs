using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ToolbarPopupSearchField ToolbarPopupSearchField (VisualElement parent = null)
        {
            ToolbarPopupSearchField toolbarPopupSearchField = new ToolbarPopupSearchField();
            toolbarPopupSearchField.SetParent(parent);
            return toolbarPopupSearchField;
        }

    }
}