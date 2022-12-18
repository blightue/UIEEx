using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout 
    {
        public static ProgressBar ProgressBar (VisualElement parent = null)
        {
            ProgressBar progressBar = new ProgressBar();
            progressBar.SetParent(parent);
            return progressBar;
        }

    }
}