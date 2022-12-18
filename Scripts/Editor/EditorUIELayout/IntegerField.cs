using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static IntegerField IntegerField (VisualElement parent = null)
        {
            IntegerField integerField = new IntegerField();
            integerField.SetParent(parent);
            return integerField;
        }

        public static IntegerField IntegerField (System.Int32 maxLength, VisualElement parent = null)
        {
            IntegerField integerField = new IntegerField(maxLength);
            integerField.SetParent(parent);
            return integerField;
        }

        public static IntegerField IntegerField (System.String label, System.Int32 maxLength, VisualElement parent = null)
        {
            IntegerField integerField = new IntegerField(label, maxLength);
            integerField.SetParent(parent);
            return integerField;
        }

    }
}