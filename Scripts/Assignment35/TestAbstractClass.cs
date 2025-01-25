using UnityEngine;
namespace assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        DerivedClassExample derived = new DerivedClassExample();
        void Start()
        {
            derived.PerformeAction();
            derived.PrintInfo();
        }
    }
}
