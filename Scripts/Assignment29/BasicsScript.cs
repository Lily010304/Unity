using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29
{
public class Basics : MonoBehaviour
{
    
    void Start()
    {
        var number = 7;
        var name = "Layla";
        var isEmpty = false;

        Debug.Log((number % 2 == 1) ? $"The  number {number} is odd" : $"The number {number} is not odd");

        Debug.Log(System.DateTime.Now.ToShortDateString());
        Debug.Log(System.DateTime.Now.ToShortTimeString());
        Debug.Log(System.DateTime.Now.DayOfWeek);

    }


}
}
