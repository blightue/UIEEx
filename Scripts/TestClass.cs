using UnityEngine;

    public class TestClass : MonoBehaviour
    {
        public string name = "NAME";
        public int ID = -1;
        

        public void Debug()
        {
            UnityEngine.Debug.Log($"name: {name} ID: {ID}");
        }
    }
