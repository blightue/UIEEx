using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static GroupBox GroupBox (VisualElement parent = null)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.SetParent(parent);
            return groupBox;
        }

        public static GroupBox GroupBox (System.String text, VisualElement parent = null)
        {
            GroupBox groupBox = new GroupBox(text);
            groupBox.SetParent(parent);
            return groupBox;
        }

    }
}