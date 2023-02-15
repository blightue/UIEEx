using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace SuiSuiShou.UIEEx.Editor
{
    public static partial class UIEExtension
    {
        /// <summary>
        /// Set the bind object of the target element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="serializedObj"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T SetBindObject<T>(this T target, SerializedObject serializedObj) where T : BindableElement
        {
            target.Bind(serializedObj);
            return target;
        }
    }
}