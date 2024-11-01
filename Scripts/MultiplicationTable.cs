using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int multiply(int num1, int num2)
    {
        return (num1 * num2);
    }

    void Start()
    {
        int multiplied = 5;
        for (int i = 1; i <= 10; i++)
        {
            int result = multiply(multiplied, i);
            Debug.Log(multiplied + " x " + i + " = " + result);
        }

    }
}
