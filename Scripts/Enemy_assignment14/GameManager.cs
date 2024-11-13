using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player0 = new Player();
        Debug.Log(player0.Name);
        Debug.Log(player0.Health);

        Enemy enemy0 = new Enemy();
        Debug.Log(enemy0.Name);
        Debug.Log(enemy0.Health);

        enemy0.Attack(player0, 24);
        Debug.Log(player0.Health);
        player0.Heal(10);

        Debug.Log(player0.Health);

    }
}
