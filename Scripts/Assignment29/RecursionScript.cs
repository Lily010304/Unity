using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace Assignment29
{
public class RecursionScript : MonoBehaviour
{
    public int num1 = 10;
    public int num2 = 30;
    public int FibonacciRecursive(int n)
    {
        if (n == 1 || n == 0)
        {
            return n;
        }
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    void Start()
    {
        Debug.Log(FibonacciRecursive(num1));
        Debug.Log(FibonacciRecursive(num2));
        Debug.Log(FibonacciLoop(num1));
        Debug.Log(FibonacciLoop(num2));

        
    }

    public int FibonacciLoop(int n)
    {
        int result = 0;
        if (n == 1 || n == 0)
        return n;
        int p = 0;
        int a = 1;
        for (int i = 2; i <= n; i++)
        {
            result = a + p;
            p = a;
            a = result;

        }

        return result;
    
}

    void Update()
    {
        
    }
}
}
