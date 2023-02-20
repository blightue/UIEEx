# Method chaining

## Principle

UIEEx provide method chaining for elements, you can use `Set[Property]` to set element property.

## API

Check all supported properties in [ElementExtension](https://blightue.github.io/UIEEx/api/SuiSuiShou.UIEEx.UIEExtension.html#methods) api documentation.

## Sample:

```csharp
Button button = UIELayout.Butto(rootVisualElement)
  .SetBindingPath("m_ButtonName")
  .SetBindObject(serializedObject);
```