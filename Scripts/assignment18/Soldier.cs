using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment18
{
    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) 
        : base(name, health, position) { }

        public Soldier() : base(){}

        public override void DisplayInfo()
        {
            Debug.Log("This is Soldier");
            base.DisplayInfo();
        }
    }
}