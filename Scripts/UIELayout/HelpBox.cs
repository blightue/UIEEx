using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static HelpBox HelpBox (VisualElement parent = null)
        {
            HelpBox helpBox = new HelpBox();
            helpBox.SetParent(parent);
            return helpBox;
        }

        public static HelpBox HelpBox (System.String text, UnityEngine.UIElements.HelpBoxMessageType messageType, VisualElement parent = null)
        {
            HelpBox helpBox = new HelpBox(text, messageType);
            helpBox.SetParent(parent);
            return helpBox;
        }

    }
}