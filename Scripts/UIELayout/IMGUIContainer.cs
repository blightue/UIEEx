using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static IMGUIContainer IMGUIContainer (VisualElement parent = null)
        {
            IMGUIContainer iMGUIContainer = new IMGUIContainer();
            iMGUIContainer.SetParent(parent);
            return iMGUIContainer;
        }

        public static IMGUIContainer IMGUIContainer (System.Action onGUIHandler, VisualElement parent = null)
        {
            IMGUIContainer iMGUIContainer = new IMGUIContainer(onGUIHandler);
            iMGUIContainer.SetParent(parent);
            return iMGUIContainer;
        }

    }
}