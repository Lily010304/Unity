using UnityEngine;
namespace assignment35
{
    public class BoxingUnBoxing : MonoBehaviour
    {
        Object cobj;
        Object unboxed;
        public int score = 100;
        void Start()
        {
            Debug.Log(score);
            object cobj = score;
            Debug.Log(cobj);
            int unboxed = (int)cobj;
            unboxed -= 50;
            Debug.Log(unboxed);
        }
    }
}
