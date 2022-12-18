using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static CurveField CurveField (VisualElement parent = null)
        {
            CurveField curveField = new CurveField();
            curveField.SetParent(parent);
            return curveField;
        }

        public static CurveField CurveField (System.String label, VisualElement parent = null)
        {
            CurveField curveField = new CurveField(label);
            curveField.SetParent(parent);
            return curveField;
        }

    }
}