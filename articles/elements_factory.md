# Elements Factory

## Principle

* use `UIELayout.[ElementName]([ElementConstructor Parameters], [Parent Elemen(Optional Arguments)])` to create visualelements. If parent parameter is specified,the element will be added to its parentelement automatically.

## Sample:

```csharp
// Label Element Constructor:
// Label label = new Label("Content");
Label label = UIELayout.Label("Content",rootVisualElement);
```
  
## Namespace

* class `UIELayout` for elements which in`UnityEngine.UIElements`
* class `EditorUIELayout` for elements whichin `UnityEditor.UIElements`