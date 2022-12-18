using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Toggle Toggle (VisualElement parent = null)
        {
            Toggle toggle = new Toggle();
            toggle.SetParent(parent);
            return toggle;
        }

        public static Toggle Toggle (System.String label, VisualElement parent = null)
        {
            Toggle toggle = new Toggle(label);
            toggle.SetParent(parent);
            return toggle;
        }

    }
}