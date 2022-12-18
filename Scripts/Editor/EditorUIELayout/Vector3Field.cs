using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Vector3Field Vector3Field (VisualElement parent = null)
        {
            Vector3Field vector3Field = new Vector3Field();
            vector3Field.SetParent(parent);
            return vector3Field;
        }

        public static Vector3Field Vector3Field (System.String label, VisualElement parent = null)
        {
            Vector3Field vector3Field = new Vector3Field(label);
            vector3Field.SetParent(parent);
            return vector3Field;
        }

    }
}