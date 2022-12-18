using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static DoubleField DoubleField (VisualElement parent = null)
        {
            DoubleField doubleField = new DoubleField();
            doubleField.SetParent(parent);
            return doubleField;
        }

        public static DoubleField DoubleField (System.Int32 maxLength, VisualElement parent = null)
        {
            DoubleField doubleField = new DoubleField(maxLength);
            doubleField.SetParent(parent);
            return doubleField;
        }

        public static DoubleField DoubleField (System.String label, System.Int32 maxLength, VisualElement parent = null)
        {
            DoubleField doubleField = new DoubleField(label, maxLength);
            doubleField.SetParent(parent);
            return doubleField;
        }

    }
}