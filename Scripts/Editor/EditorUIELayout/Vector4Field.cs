using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Vector4Field Vector4Field (VisualElement parent = null)
        {
            Vector4Field vector4Field = new Vector4Field();
            vector4Field.SetParent(parent);
            return vector4Field;
        }

        public static Vector4Field Vector4Field (System.String label, VisualElement parent = null)
        {
            Vector4Field vector4Field = new Vector4Field(label);
            vector4Field.SetParent(parent);
            return vector4Field;
        }

    }
}