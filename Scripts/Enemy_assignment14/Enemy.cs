using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public void Attack(Character target, int amount)
    {
        target.Health -= amount;

        if (target.Health > 100) target.Health = 100;
        else if (target.Health < 0) target.Health = 0;
    }
}
