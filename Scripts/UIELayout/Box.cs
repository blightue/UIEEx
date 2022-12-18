using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Box Box (VisualElement parent = null)
        {
            Box box = new Box();
            box.SetParent(parent);
            return box;
        }

    }
}