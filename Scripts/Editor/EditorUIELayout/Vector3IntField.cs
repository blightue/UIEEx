using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Vector3IntField Vector3IntField (VisualElement parent = null)
        {
            Vector3IntField vector3IntField = new Vector3IntField();
            vector3IntField.SetParent(parent);
            return vector3IntField;
        }

        public static Vector3IntField Vector3IntField (System.String label, VisualElement parent = null)
        {
            Vector3IntField vector3IntField = new Vector3IntField(label);
            vector3IntField.SetParent(parent);
            return vector3IntField;
        }

    }
}