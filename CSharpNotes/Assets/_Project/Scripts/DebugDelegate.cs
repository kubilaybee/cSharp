using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDelegate : MonoBehaviour
{
    public delegate void DelegateDebug();   // define
    public DelegateDebug delegateDebug;     // create object

    // start
    private void Start()
    {
        // add method
        //delegateDebug += Debug1;
        //delegateDebug += Debug2;

        delegateDebug += Debug1;
        AddMethod(Debug2);
        RemoveMethod(Debug1);

        if (delegateDebug != null)
        {
            delegateDebug();
        }
    }

    private void Debug1()
    {
        Debug.Log("Debug -1");
    }
    private void Debug2()
    {
        Debug.Log("Debug -2");
    }

    public void AddMethod(DelegateDebug method)
    {
        delegateDebug += method;
    }

    public void RemoveMethod(DelegateDebug method)
    {
        delegateDebug -= method;
    }
}
