using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static BoundsIntField BoundsIntField (VisualElement parent = null)
        {
            BoundsIntField boundsIntField = new BoundsIntField();
            boundsIntField.SetParent(parent);
            return boundsIntField;
        }

        public static BoundsIntField BoundsIntField (System.String label, VisualElement parent = null)
        {
            BoundsIntField boundsIntField = new BoundsIntField(label);
            boundsIntField.SetParent(parent);
            return boundsIntField;
        }

    }
}