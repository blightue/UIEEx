using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using SuiSuiShou.UIEEx;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class TestEditorWindow : EditorWindow
{
    public DataStore data;

    public SerializedObject dataSerial;

    private TestClass test;

    [MenuItem("Tools/TestEditorWindow")]
    public static void Init()
    {
        TestEditorWindow ew = GetWindow<TestEditorWindow>();
    }

    private void CreateGUI()
    {
        TextField textField = new TextField("name");
        textField.bindingPath = nameof(TestClass.name);
        rootVisualElement.Add(textField);
        rootVisualElement.Add(
            UIELayout.HorzontalLayout(
                UIELayout.Button("Debug", () => test.Debug())
            )
        );
        
        ObjectField objectField = new ObjectField("TestClass");
        objectField.objectType = typeof(TestClass);
        objectField.allowSceneObjects = true;
        objectField.RegisterCallback<ChangeEvent<UnityEngine.Object>>(
            e =>
            {
                test = (TestClass) e.newValue; 
                textField.Bind(new SerializedObject(test));
            }
        );

        rootVisualElement.Add(objectField);

    }

    [Serializable]
    public class DataStore : Object
    {
        public string name;

        public int ID;

        public DataStore()
        {
            this.name = "name";
            this.ID = 0;
        }

        public void Debug()
        {
            UnityEngine.Debug.Log($"name: {name} ID: {ID}");
        }
    }
}