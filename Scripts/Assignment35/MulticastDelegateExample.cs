using UnityEngine;

namespace assignment35
{
  delegate void MathOperation(int num);
  public class NewBehaviourScript : MonoBehaviour
  {
    public void DoubleNumber(int num) => Debug.Log("number doubled is:" + (num * 2));
    public void SquareNumber(int num) => Debug.Log("number squared is:" + (num * num));
    public void CubeNumber(int num) => Debug.Log("number cubed is:" + (num * num * num));
    MathOperation operation;
    void Start()
    {
      operation += DoubleNumber;
      operation += SquareNumber;
      operation += CubeNumber;
      operation(5);
    }
  }
}
