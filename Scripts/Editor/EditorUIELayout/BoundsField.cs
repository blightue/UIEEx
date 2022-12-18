using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static BoundsField BoundsField (VisualElement parent = null)
        {
            BoundsField boundsField = new BoundsField();
            boundsField.SetParent(parent);
            return boundsField;
        }

        public static BoundsField BoundsField (System.String label, VisualElement parent = null)
        {
            BoundsField boundsField = new BoundsField(label);
            boundsField.SetParent(parent);
            return boundsField;
        }

    }
}