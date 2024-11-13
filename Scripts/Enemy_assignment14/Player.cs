using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public void Heal(int amount)
    {
        Health += amount;

        if (Health > 100)
            Health = 100;
        else if (Health < 0)
            Health = 0;
    }
}
