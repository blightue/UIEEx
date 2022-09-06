using System;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using SuiSuiShou.UIEEx;
using UnityEngine;

[CustomEditor(typeof(TestClass))]
public class TestEditor : Editor
{
    private TestClass test;

    private void OnEnable()
    {
        test = target as TestClass;
    }


    public override VisualElement CreateInspectorGUI()
    {
        VisualElement root = new VisualElement();

        // TextField textField = new TextField("name");
        // textField.bindingPath = "name";
        // textField.style.flexGrow = new StyleFloat(1f);
        // textField.labelElement.style.minWidth = new StyleLength(StyleKeyword.Auto);

        //root.Add(textField);
        IntegerField intField = new IntegerField("ID");

        intField.bindingPath = "ID";
        //root.Add(intField);

        UIELayout.Button("Debug", () => test.Debug(), root);

        root.Add((UIELayout.Box(FlexDirection.Column,
            UIELayout.TextField("Name", parent: root),
            intField)));

        return root;
    }
}