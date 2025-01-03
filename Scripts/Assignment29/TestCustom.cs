using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class TestCustom : MonoBehaviour
{
    CustomObject obj;
    CustomObject obj2;

    void Start()
    {
        obj = new CustomObject(2, "Lily");
        obj2 = new CustomObject(3, "Lily");
        Debug.Log(obj == obj2);
        Debug.Log(obj != obj2);

        
    }
}
}
