using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static ObjectField ObjectField (VisualElement parent = null)
        {
            ObjectField objectField = new ObjectField();
            objectField.SetParent(parent);
            return objectField;
        }

        public static ObjectField ObjectField (System.String label, VisualElement parent = null)
        {
            ObjectField objectField = new ObjectField(label);
            objectField.SetParent(parent);
            return objectField;
        }

    }
}