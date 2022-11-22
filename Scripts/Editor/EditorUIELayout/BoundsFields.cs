using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class EditorUIELayout
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">UnityEngine.Bounds</param>
        /// <returns></returns>
        public static BoundsField BoundsField(string text, VisualElement parent = null)
        {
            BoundsField boundsField = BoundsField(parent);

            boundsField.label = text;

            return boundsField;
        }

        public static BoundsField BoundsField(VisualElement parent = null)
        {
            BoundsField boundsField = new BoundsField();

            boundsField.SetParent(parent);

            return boundsField;
        }
    }
}