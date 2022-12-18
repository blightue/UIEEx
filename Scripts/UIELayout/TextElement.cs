using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static TextElement TextElement (VisualElement parent = null)
        {
            TextElement textElement = new TextElement();
            textElement.SetParent(parent);
            return textElement;
        }

    }
}