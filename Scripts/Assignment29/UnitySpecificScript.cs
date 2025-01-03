using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class UnitySpecificScript : MonoBehaviour
{
    public GameObject TargetObject;

    void OnEnable()
    {
        print("GameObject Enabled");
    }

    void OnDisable()
    {
        print("GameObject Disabled");
    }
    void Start()
    {
        print("Game started!");
        GameObject target = GameObject.Find("TargetObject");

        if (target)
        {
            print(target.name);
        }
        else
        {
            print("No TargetObject found.");
        }


        GameObject joker = GameObject.FindGameObjectWithTag("Joker");

        if (joker)
        {
            print(joker.name);
        }
        else
        {
            print("No joker found.");
        }

        Light light = GameObject.FindObjectOfType<Light>();

        if (light)
        {
            print(light.name);
        }
        else
        {
            print("No light found.");
        }

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            TargetObject.SetActive(false);
            print("TargetObject deactivated!");
        }

    }
}
}
