using UnityEngine;
namespace assignment35
{
public abstract class AbstractBaseClass
{
    public abstract void PerformeAction();
    public  void PrintInfo()=>Debug.Log("This is a concrete method in the abstract base class.");
}
}
