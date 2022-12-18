using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static GradientField GradientField (VisualElement parent = null)
        {
            GradientField gradientField = new GradientField();
            gradientField.SetParent(parent);
            return gradientField;
        }

        public static GradientField GradientField (System.String label, VisualElement parent = null)
        {
            GradientField gradientField = new GradientField(label);
            gradientField.SetParent(parent);
            return gradientField;
        }

    }
}