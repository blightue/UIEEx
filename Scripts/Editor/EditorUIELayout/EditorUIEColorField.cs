using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx
{
    public static partial class EditorUIELayout
    {
        public static ColorField ColorField(bool hdr = false, bool showAlpha = false, bool showEyedropper = false,
            VisualElement parent = null)
        {
            return ColorField(null, hdr, showAlpha, showEyedropper, parent);
        }

        public static ColorField ColorField
            (string label, bool hdr = false, bool showAlpha = false, bool showEyedropper = false, VisualElement parent = null)
        {
            ColorField colorField = new ColorField();

            if (label != null) colorField.label = label;
            if (parent != null) parent.Add(colorField);
            colorField.hdr = hdr;
            colorField.showAlpha = showAlpha;
            colorField.showEyeDropper = showEyedropper;

            return colorField;
        }
    }
}