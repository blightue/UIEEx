# UIEEx

![version](https://img.shields.io/github/package-json/v/blightue/UIEEx) ![license](https://img.shields.io/github/license/blightue/UIEEx)

UIEEx(UIElement Extension) is an extension library of Unity UI Elements package. UIEEx improve the workflow of creating editor &amp; runtime UI with UI Elements.

[Full Documentation](https://blightue.github.io/UIEEx/)

## Getting Started

### Installation instructions

#### Unity package manager(Git)

1. Go to **Package Manager** window via `Window/Package Manager`
2. Click the **add** ![img](https://docs.unity3d.com/uploads/Main/iconAdd.png) button in the status bar
3. Select **Add package from git URL** from the add menu
4. Fill the git URL with https://github.com/blightue/UIEEx.git and click **Add**

#### Unity package manager(Local)

1. Download and unzip the source code to your disk
2. Go to **Package Manager** window via `Window/Package Manager`
3. Click the **add** ![img](https://docs.unity3d.com/uploads/Main/iconAdd.png) button in the status bar
4. Select **Add package from disk** from the add menu
5. Select the **package.json** file in the unzipped folder

### Quick Start

#### Elements Factory

 * use `UIELayout.[ElementName]([Element Constructor Parameters], [Parent Element(Optional Arguments)])` to create visual elements. If parent parameter is specified, the element will be added to its parent element automatically.

 * Sample:
    ```csharp
    // Label Element Constructor:
    // Label label = new Label("Content");
    Label label = UIELayout.Label("Content", rootVisualElement);
    ```
  
 * class `UIELayout` for elements which in `UnityEngine.UIElements`
 * class `EditorUIELayout` for elements which in `UnityEditor.UIElements`

#### Method chaining

 * UIEEx provide method chaining for elements, you can use `Set[Property]` to set element property.
  
 * Check all supported properties in [ElementExtension](https://blightue.github.io/UIEEx/api/SuiSuiShou.UIEEx.UIEExtension.html#methods) api documentation.

 * Sample:
    ```csharp
    Button button = UIELayout.Button(rootVisualElement)
      .SetBindingPath("m_ButtonName")
      .SetBindObject(serializedObject);
    ```

#### Samples

* EditorWindow Sample

    ```c#
    public class UIEExSample : EditorWindow
    {
        [SerializeField] private int clickedCount = 0;
    
        [MenuItem("Tools/UIEEx Sample")]
        private static void ShowWindow()
        {
            var window = GetWindow<UIEExSample>();
            window.Show();
        }
    
        private void CreateGUI()
        {
            Label label = UIELayout.Label("Click the btn below", rootVisualElement);
            Button btn = UIELayout.Button
                (() =>
                {
                    clickedCount += 1;
                    label.SetText("Button clicked " + clickedCount + " times");
                }, rootVisualElement)
                .SetText("Click me");
        }
    }
    ```

* Custom Editor Sample
    ```csharp
    [CustomEditor(typeof(TestClass))]
    public class TestClassEditor : UnityEditor.Editor
    {
        private TestClass _target;

        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement  ();

            TextField inputField = UIELayout.   TextField("My Text", root)
                .SetBindingPath(nameof(_target. m_Text));

            IntegerField countField =   EditorUIELayout.IntegerField("My  Count", 100, root)
                .SetBindingPath(nameof(_target. m_Count));

            return root;
        }
    }
    ```
