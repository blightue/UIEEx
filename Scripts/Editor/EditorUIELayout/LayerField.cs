using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static LayerField LayerField (System.String label, VisualElement parent = null)
        {
            LayerField layerField = new LayerField(label);
            layerField.SetParent(parent);
            return layerField;
        }

        public static LayerField LayerField (VisualElement parent = null)
        {
            LayerField layerField = new LayerField();
            layerField.SetParent(parent);
            return layerField;
        }

        public static LayerField LayerField (System.Int32 defaultValue, VisualElement parent = null)
        {
            LayerField layerField = new LayerField(defaultValue);
            layerField.SetParent(parent);
            return layerField;
        }

        public static LayerField LayerField (System.String label, System.Int32 defaultValue, VisualElement parent = null)
        {
            LayerField layerField = new LayerField(label, defaultValue);
            layerField.SetParent(parent);
            return layerField;
        }

    }
}