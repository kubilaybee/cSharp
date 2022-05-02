using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DebugDelegateMath : MonoBehaviour
{
    // define
    public delegate int CalculateDelegate(int x1, int x2);
    public CalculateDelegate calculateDelegate;

    private void Start()
    {
        calculateDelegate += Addition;   
        calculateDelegate += Subtraction;   
        calculateDelegate += Multiplication;
        // add lambda function
        calculateDelegate += (int a, int b) =>
        {
            Debug.Log("Divide");
            return a / b;
        }; 

        //calculateDelegate(13, 3);

        Delegate[] funcs = calculateDelegate.GetInvocationList();   // delegate array has been funcs

        for (int i = 0; i < funcs.Length; i++)
        {
            // delegate to calculatedelegate -> after that run
            int result =  ((CalculateDelegate)funcs[i]).Invoke(13,3);
            Debug.Log(result);
        }

    }

    // Addition
    private int Addition(int a, int b)
    {
        Debug.Log("Addition!!");
        return a + b;
    }
    // Subtraction
    private int Subtraction(int a, int b)
    {
        Debug.Log("Subtraction!!");
        return a - b;
    }
    // Multiplication
    private int Multiplication(int a, int b)
    {
        Debug.Log("Multiplication!!");
        return a * b;
    }

}
