using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Toolbar Toolbar (VisualElement parent = null)
        {
            Toolbar toolbar = new Toolbar();
            toolbar.SetParent(parent);
            return toolbar;
        }

    }
}