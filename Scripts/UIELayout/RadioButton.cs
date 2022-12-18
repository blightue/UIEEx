using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static RadioButton RadioButton (VisualElement parent = null)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.SetParent(parent);
            return radioButton;
        }

        public static RadioButton RadioButton (System.String label, VisualElement parent = null)
        {
            RadioButton radioButton = new RadioButton(label);
            radioButton.SetParent(parent);
            return radioButton;
        }

    }
}