using UnityEngine;

    public class TestClass : MonoBehaviour
    {
        public string name = "NAME";
        public int ID = -1;
        public Numb numb;
        
        public float floatValue;
        
        public string value;

        public Vector2 minMax;

        public void Debug()
        {
            UnityEngine.Debug.Log($"name: {name} ID: {ID}");
        }
    }


public enum Numb { F, D, E, G}