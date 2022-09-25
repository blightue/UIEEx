using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        public static ProgressBar ProgressBar(string text,float lowValue, float highValue,  VisualElement parent = null)
        {
            ProgressBar progressBar = new ProgressBar();

            progressBar.title = text;
            progressBar.highValue = highValue;
            progressBar.lowValue = lowValue;
            progressBar.SetParent(parent);
            
            return progressBar;
        }
    }
}