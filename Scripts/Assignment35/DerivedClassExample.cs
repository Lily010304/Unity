using UnityEngine;
namespace assignment35
{
    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformeAction() => Debug.Log("PerformAction is implemented in the derived class.");
    }
}
