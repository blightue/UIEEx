# Samples

## EditorWindow

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

## Custom Editor

```csharp
[CustomEditor(typeof(TestClass))]
public class TestClassEditor : UnityEditorEditor
{
    private TestClass _target;
    public override VisualElement CreateInspectorGUI()
    {
        VisualElement root = new VisualElement();
        TextField inputField = UIELayout.TextField("My Text", root)
            .SetBindingPath(nameof(_target.m_Text));
        IntegerField countField = EditorUIELayout.IntegerField("My Count", 100, root)
            .SetBindingPath(nameof(_target.m_Count));
        return root;
    }
}
```