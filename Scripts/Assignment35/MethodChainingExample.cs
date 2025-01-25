using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment35
{
public class MethodChainingExample : MonoBehaviour
{
    public MethodChainingExample ChangePosition(Vector3 position)
    {
        transform.position = position;
        return this;
    }
    public MethodChainingExample ChangeRotation(Vector3 rotation)
    {
        transform.rotation=Quaternion.Euler(rotation);
        return this;
    }
    public MethodChainingExample ChangeScale(Vector3 scale)
    {
        transform.localScale=scale;
        return this;
    }
    void Start()
    {
        ChangePosition(new Vector3(2,2,3));
        ChangeRotation(new Vector3(45,0,0));
        ChangeScale(new Vector3(4,4,4));
    }
}
}
