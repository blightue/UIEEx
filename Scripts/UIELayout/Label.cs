using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Label Label (VisualElement parent = null)
        {
            Label label = new Label();
            label.SetParent(parent);
            return label;
        }

        public static Label Label (System.String text, VisualElement parent = null)
        {
            Label label = new Label(text);
            label.SetParent(parent);
            return label;
        }

    }
}