using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static class UIEExtension
    {
        public static VisualElement SetParent(this VisualElement target, VisualElement parent)
        {
            if(parent != null) parent.Add(target);
            return target;
        }
    }
}