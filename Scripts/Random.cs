using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int random = UnityEngine.Random.Range(1, 21);
            if (random == 5)
            continue;

            if (random == 15)
            break;

            Debug.Log(random);

        }
    }

}