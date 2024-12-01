using System.Collections;
using System.Collections.Generic;
using Generic;
using UnityEngine;

namespace Generic
{
public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> test = new GameContainer<string>();
        test.SetItem("Healing Potion");

        Debug.Log("Get Item Method : " + test.GetItem());
        GameUtils.DescribeItem(test);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
