using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character 
    {
        string name;
        public int health;
        public Position position;

        public string Name { get; set; }



        public int Health
        {
            get {return health;}
            set {health += value;
            if (health > 100) health = 100;
            else if (health < 0) health = 0;}
        }

        public Character (string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log("The name :" + name);
            Debug.Log("The Health : " + health);
            position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.health = target.health - damage;
        }

        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log(name + " Attacks " + target.name + " with " + attackType);
            Attack(damage, target);
        }
    }
}