using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static TagField TagField (VisualElement parent = null)
        {
            TagField tagField = new TagField();
            tagField.SetParent(parent);
            return tagField;
        }

        public static TagField TagField (System.String label, System.String defaultValue, VisualElement parent = null)
        {
            TagField tagField = new TagField(label, defaultValue);
            tagField.SetParent(parent);
            return tagField;
        }

    }
}