using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace Invent
{
public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potions = new Inventory();
        potions.AddItem("Healing Potion");

        potions.AddItem("Strength Potion");

        Inventory elixirs = new Inventory();

        elixirs.AddItem("Elixir");
        elixirs.AddItem("Dark Elixir");

        Inventory combined;
        combined = potions + elixirs;
        combined.ShowItems();


    }

    
   
}
}
