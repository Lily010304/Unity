using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action Logmessage = () => Debug.Log("Action worked!");
        Func<int, int> square = (num) => num * num;
        Predicate<int> iseven = (num) => num % 2 == 0;
        void Start()
        {
            Logmessage();
            Debug.Log($"Square : {square(5)}");
            Debug.Log($"Is 4 even? {iseven(4)}");
        }
    }
}
