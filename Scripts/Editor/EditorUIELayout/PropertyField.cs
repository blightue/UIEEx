using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static PropertyField PropertyField (VisualElement parent = null)
        {
            PropertyField propertyField = new PropertyField();
            propertyField.SetParent(parent);
            return propertyField;
        }

        public static PropertyField PropertyField (UnityEditor.SerializedProperty property, VisualElement parent = null)
        {
            PropertyField propertyField = new PropertyField(property);
            propertyField.SetParent(parent);
            return propertyField;
        }

        public static PropertyField PropertyField (UnityEditor.SerializedProperty property, System.String label, VisualElement parent = null)
        {
            PropertyField propertyField = new PropertyField(property, label);
            propertyField.SetParent(parent);
            return propertyField;
        }

    }
}