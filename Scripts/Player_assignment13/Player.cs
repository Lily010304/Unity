using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    string playerName;
    int health = 100;
    static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Health(int amount)
    {
        health += amount;
        Debug.Log(health);
    }

    public void Health(bool fullRestore)
    {
        if (fullRestore)
            health = 100;
    }

    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
