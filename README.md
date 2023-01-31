# UIEEx

![version](https://badgen.net/badge/version/0.1.0/orange) ![license](https://badgen.net/github/license/blightue/UIEEx)

UIEEx(UIElement Extension) is an extension library of Unity UI Elements package. UIEEx improve the workflow of creating editor &amp; runtime UI with UI Elements.

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

#### Create visual elements

* Elements Factory

  From:
  ```csharp
  Label label = new Label("Content");
  label.SetParent(rootVisualElement);
  ```
  
  To:
  ```csharp
  Label label = UIELayout.Label("Content", rootVisualElement);
  ```

* EditorWindow Sample

    ```c#
    public class UIEExSamplw : EditorWindow
    {
        [SerializeField] private int clickedCount = 0;
    
        [MenuItem("Tools/UIEEx Sample")]
        private static void ShowWindow()
        {
            var window = GetWindow<UIEExSamplw>();
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
* Inspector