using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Soldier soldier = new Soldier();
            Officer officer = new Officer("The Sherif Carl John", 100, new Position(10, 5, 20));
            Character[] charactrs = {soldier, officer};

            foreach (Character character in charactrs)
            {
                character.DisplayInfo();
            }

            Debug.Log(soldier.Health);
            officer.Attack(25, soldier, "Shooting");
            Debug.Log(soldier.Health);
        }

    }
}
