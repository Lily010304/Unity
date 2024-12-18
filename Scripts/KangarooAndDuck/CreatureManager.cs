using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment26;
public class CreatureManager : MonoBehaviour
{
    Kangaroo kangaroo = new Kangaroo();
    Duck duck = new Duck();

    List<Creature> creatures;

    List <IRunnable> runners;

    List<IJumpable> jumpers;

    List<ISwimmable> swimmers;
    void Start()
    {
        creatures = new List<Creature> {kangaroo, duck};

        runners = new List<IRunnable> {kangaroo, duck};

        jumpers = new List<IJumpable> {kangaroo};

        swimmers = new List<ISwimmable> {duck};

        foreach (Creature creature in creatures)
        {
            creature.Speak();
        }

        foreach (IRunnable runner in runners)
        {
            runner.Run();
        }

        foreach (IJumpable jumper in jumpers)
        {
            jumper.Jump();
        }

        foreach (ISwimmable swimmer in swimmers)
        {
            swimmer.Swim();
        }
    }

  
}
