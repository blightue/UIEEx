using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static LongField LongField (VisualElement parent = null)
        {
            LongField longField = new LongField();
            longField.SetParent(parent);
            return longField;
        }

        public static LongField LongField (System.Int32 maxLength, VisualElement parent = null)
        {
            LongField longField = new LongField(maxLength);
            longField.SetParent(parent);
            return longField;
        }

        public static LongField LongField (System.String label, System.Int32 maxLength, VisualElement parent = null)
        {
            LongField longField = new LongField(label, maxLength);
            longField.SetParent(parent);
            return longField;
        }

    }
}