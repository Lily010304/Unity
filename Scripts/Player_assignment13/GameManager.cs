using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        player1.InitializePlayer("Leon", 100);
        player1.Health(-10);
        player1.Health(true);
        Player player2 = new Player();
        player2.InitializePlayer("Theo", 34);
        player2.Health(1);
        player2.Health(true);
        Player.ShowPlayerCount();
    }
}
