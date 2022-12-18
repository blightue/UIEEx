using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Vector2Field Vector2Field (VisualElement parent = null)
        {
            Vector2Field vector2Field = new Vector2Field();
            vector2Field.SetParent(parent);
            return vector2Field;
        }

        public static Vector2Field Vector2Field (System.String label, VisualElement parent = null)
        {
            Vector2Field vector2Field = new Vector2Field(label);
            vector2Field.SetParent(parent);
            return vector2Field;
        }

    }
}