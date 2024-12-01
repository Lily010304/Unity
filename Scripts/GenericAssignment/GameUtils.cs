using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Generic
{
public class GameUtils
{
    public static void DescribeItem<T>(GameContainer<T> item)
    {
        Debug.Log("This Item is a " + item.GetItem());
    }
}

}
