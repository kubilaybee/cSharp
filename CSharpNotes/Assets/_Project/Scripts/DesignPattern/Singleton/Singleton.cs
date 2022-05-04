using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance = null;
    private string text;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("Singleton").AddComponent<Singleton>();
            }
            return instance;
        }
    }

    private void OnEnable()
    {
        instance = this;
        text = "Hello World";
    }

    public string GetText()
    {
        return text;
    }
}
