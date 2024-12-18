using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByValueByReference : MonoBehaviour
{
    void Start()
    {
        int outVariable;
        int x = 7;

        int y = 9;

        Debug.Log($"The Number x before passing it to the changing by value function: {x}");
        ChangeNumber(x);
        Debug.Log($"The Number x after passing it to the changing by value function: {x}");


        Debug.Log($"The Number y before passing it to the changing by reference function: {y}");
        ChangeNumber(ref y);
        Debug.Log($"The Number y after passing it to the changing by reference function: {y}");

        ChangeNumber2(out outVariable);
        Debug.Log($"The Number out Variable after passing it to the out keyword function: {outVariable}");


        
    }

    void ChangeNumber(int a)
    {
        a += 11;
    }

    void ChangeNumber(ref int a)
    {
        a += 6;
    }

    void ChangeNumber2(out int a)
    {
        a = 6;
    }
}
