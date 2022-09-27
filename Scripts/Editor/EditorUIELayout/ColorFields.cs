using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class EditorUIELayout
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdr"></param>
        /// <param name="showAlpha"></param>
        /// <param name="showEyedropper"></param>
        /// <param name="parent"></param>
        /// <param name="bindingPath">UnityEngine.Color</param>
        /// <returns></returns>
        public static ColorField ColorField(bool hdr = false, bool showAlpha = false, bool showEyedropper = false,
            VisualElement parent = null, string bindingPath = default)
        {
            return ColorField(null, hdr, showAlpha, showEyedropper, parent, bindingPath);
        }

        public static ColorField ColorField
        (string label, bool hdr = false, bool showAlpha = false, bool showEyedropper = false,
            VisualElement parent = null,
            string bindingPath = default)
        {
            ColorField colorField = new ColorField();

            colorField.label = label;

            colorField.SetParent(parent);
            colorField.SetBindingPath(bindingPath);

            colorField.hdr = hdr;
            colorField.showAlpha = showAlpha;
            colorField.showEyeDropper = showEyedropper;

            return colorField;
        }
    }
}