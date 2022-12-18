using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static FloatField FloatField (VisualElement parent = null)
        {
            FloatField floatField = new FloatField();
            floatField.SetParent(parent);
            return floatField;
        }

        public static FloatField FloatField (System.Int32 maxLength, VisualElement parent = null)
        {
            FloatField floatField = new FloatField(maxLength);
            floatField.SetParent(parent);
            return floatField;
        }

        public static FloatField FloatField (System.String label, System.Int32 maxLength, VisualElement parent = null)
        {
            FloatField floatField = new FloatField(label, maxLength);
            floatField.SetParent(parent);
            return floatField;
        }

    }
}