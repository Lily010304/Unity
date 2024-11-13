using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    static int charNum = 0;
    string name = "";
    int health = 100;

    public string Name
    {
        get
        {
           return name; 
        }
        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
           return health; 
        }
        set
        {
            if (health > 100) health = 100;
            else if (health < 0) health = 0;
            else health = value;
        }
    }

    public Character ()
    {
        this.name = "character" + charNum;
        this.health = 100;
        charNum += 1;
    }

    public Character (string name, int health)
    {
        this.name = name;
        if (health > 100) this.health = 100;
        else if (health < 0) this.health = 0;
        else
            this.health = health;
    }
}
