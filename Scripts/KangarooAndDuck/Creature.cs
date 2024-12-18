using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
public class Creature 
{
    public virtual void Speak()
    {
        Debug.Log("I am Speaking!");
    }
}

public interface IRunnable
{
    public void Run()
    {
        Debug.Log("I am Running!");
    }
}



public interface IJumpable
{
    public void Jump()
    {
        Debug.Log("I am Jumping!");
    }
}

public interface ISwimmable
{
    public void Swim()
    {
        Debug.Log("I am Swimming!");
    }
}

public class Kangaroo : Creature, IRunnable, IJumpable
{
    public void Run()
    {
        Debug.Log("Kangaroo is Running, Watch out");
    }

    public void Jump()
    {
        Debug.Log("Kangaroo is Jumpping, Careful!");
    }

    override public void Speak()
    {
        Debug.Log("Kangaroo says: Hop!");
    }
}

public class Duck : Creature, IRunnable, ISwimmable
{
    public void Run()
    {
        Debug.Log("Duck is Running, Watch out");
    }

    public void Swim()
    {
        Debug.Log("Duck is Swimming, Careful!");
    }

    override public void Speak()
    {
        Debug.Log("Duck says: Quack!");
    }
}
}
