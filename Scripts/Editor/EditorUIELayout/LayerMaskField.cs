using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static LayerMaskField LayerMaskField (System.Int32 defaultMask, VisualElement parent = null)
        {
            LayerMaskField layerMaskField = new LayerMaskField(defaultMask);
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }

        public static LayerMaskField LayerMaskField (System.String label, System.Int32 defaultMask, VisualElement parent = null)
        {
            LayerMaskField layerMaskField = new LayerMaskField(label, defaultMask);
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }

        public static LayerMaskField LayerMaskField (VisualElement parent = null)
        {
            LayerMaskField layerMaskField = new LayerMaskField();
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }

        public static LayerMaskField LayerMaskField (System.String label, VisualElement parent = null)
        {
            LayerMaskField layerMaskField = new LayerMaskField(label);
            layerMaskField.SetParent(parent);
            return layerMaskField;
        }

    }
}