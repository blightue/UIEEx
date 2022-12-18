using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Vector2IntField Vector2IntField (VisualElement parent = null)
        {
            Vector2IntField vector2IntField = new Vector2IntField();
            vector2IntField.SetParent(parent);
            return vector2IntField;
        }

        public static Vector2IntField Vector2IntField (System.String label, VisualElement parent = null)
        {
            Vector2IntField vector2IntField = new Vector2IntField(label);
            vector2IntField.SetParent(parent);
            return vector2IntField;
        }

    }
}