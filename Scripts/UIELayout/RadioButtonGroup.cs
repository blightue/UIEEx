using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static RadioButtonGroup RadioButtonGroup (VisualElement parent = null)
        {
            RadioButtonGroup radioButtonGroup = new RadioButtonGroup();
            radioButtonGroup.SetParent(parent);
            return radioButtonGroup;
        }

        public static RadioButtonGroup RadioButtonGroup (System.String label, System.Collections.Generic.List<System.String> radioButtonChoices, VisualElement parent = null)
        {
            RadioButtonGroup radioButtonGroup = new RadioButtonGroup(label, radioButtonChoices);
            radioButtonGroup.SetParent(parent);
            return radioButtonGroup;
        }

    }
}