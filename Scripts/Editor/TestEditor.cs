using System;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using SuiSuiShou.UIEEx;
using UnityEngine;
using PopupWindow = UnityEditor.PopupWindow;

[CustomEditor(typeof(TestClass))]
public class TestEditor : Editor
{
    private TestClass test;

    //private string[] choices = new[] {"AAA", "BBB", "CCC"};

    private void OnEnable()
    {
        test = target as TestClass;
    }


    public override VisualElement CreateInspectorGUI()
    {
        VisualElement root = new VisualElement();

        // UIELayout.Button("Button", () => Debug.Log("Button log"), root);
        // UIELayout.RepeatButton("RepeatButton", () => Debug.Log("Repeat Log"), root);
        // UIELayout.Scroller(0, 100, SliderDirection.Vertical, root);

        UnityEngine.UIElements.PopupWindow popupWindow = UIELayout.PopupWindow(root);

        UIELayout.HelpBox("Help Box", HelpBoxMessageType.Info, popupWindow);

        DropdownField dropdownField = UIELayout.DropdownField("DropdownField", typeof(Numb), 0, popupWindow);
        dropdownField.bindingPath = "numb";

        Slider slider = new Slider("floatValue");
        slider.SetParent(popupWindow);
        slider.highValue = 10;
        slider.lowValue = 0;
        slider.bindingPath = "floatValue";
        
        ProgressBar progressBar = UIELayout.ProgressBar("ProgressBar", 0, 10,popupWindow);
        progressBar.bindingPath = "floatValue";

        UIELayout.Toggle( popupWindow);

        TwoPaneSplitView splitView = UIELayout.TwoPaneSplitView(popupWindow);
        var leftView = new VisualElement();
        var rightView = new VisualElement();
        splitView.Add(leftView);
        splitView.Add(rightView);
        UIELayout.Label("Left",leftView);
        UIELayout.Label("Left",leftView);
        UIELayout.Label("Right",rightView);
        
        return root;
    }
}