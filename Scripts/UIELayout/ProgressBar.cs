using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class UIELayout
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="lowValue"></param>
        /// <param name="highValue"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">float</param>
        /// <returns></returns>
        public static ProgressBar ProgressBar(string text, float lowValue, float highValue, VisualElement parent = null,
            string bindingPath = default)
        {
            ProgressBar progressBar = ProgressBar(lowValue, highValue, parent, bindingPath);
            progressBar.title = text;
            return progressBar;
        }

        public static ProgressBar ProgressBar(float lowValue, float highValue, VisualElement parent = null,
            string bindingPath = default)
        {
            ProgressBar progressBar = new ProgressBar();


            progressBar.highValue = highValue;
            progressBar.lowValue = lowValue;
            progressBar.SetParent(parent);
            progressBar.SetBindingPath(bindingPath);

            return progressBar;
        }
    }
}