using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static class UIEExtension
    {
        public static VisualElement SetParent(this VisualElement target, VisualElement parent)
        {
            parent.Add(target);
            return target;
        }
    }
}