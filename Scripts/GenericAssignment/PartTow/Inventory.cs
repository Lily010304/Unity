using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

namespace Invent
{
public class Inventory 
{
    List<string> items = new List<string>();

    public Inventory()
    {
    }

    public Inventory(List<string> items)
    {
        this.items = items;
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        foreach (string item in items)
        {
            Debug.Log(item);
        }
    }


    public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory combined = new Inventory();

        foreach (string item1 in a.items)
        {
            combined.AddItem(item1);
        }
        foreach (string item2 in b.items)
        {
            combined.AddItem(item2);
        }

        return combined;
    }
}
}


