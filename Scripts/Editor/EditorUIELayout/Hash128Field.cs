using UnityEditor.UIElements;
using UnityEngine.UIElements;
using SuiSuiShou.UIEEx;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class EditorUIELayout 
    {
        public static Hash128Field Hash128Field (VisualElement parent = null)
        {
            Hash128Field hash128Field = new Hash128Field();
            hash128Field.SetParent(parent);
            return hash128Field;
        }

        public static Hash128Field Hash128Field (System.Int32 maxLength, VisualElement parent = null)
        {
            Hash128Field hash128Field = new Hash128Field(maxLength);
            hash128Field.SetParent(parent);
            return hash128Field;
        }

        public static Hash128Field Hash128Field (System.String label, System.Int32 maxLength, VisualElement parent = null)
        {
            Hash128Field hash128Field = new Hash128Field(label, maxLength);
            hash128Field.SetParent(parent);
            return hash128Field;
        }

    }
}