using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static Foldout Foldout (VisualElement parent = null)
        {
            Foldout foldout = new Foldout();
            foldout.SetParent(parent);
            return foldout;
        }

    }
}