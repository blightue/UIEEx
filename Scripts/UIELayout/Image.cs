using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Image Image (VisualElement parent = null)
        {
            Image image = new Image();
            image.SetParent(parent);
            return image;
        }

    }
}