using System.Collections.Generic;
using UnityEngine;
namespace assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        void Start()
        {

            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log("The list in reverse is" + string.Join(", ", numbers));
            List<int> Filterednums = numbers2.FindAll((x) => x % 2 == 0);
            Debug.Log("Filtered list with even nums are" + string.Join(", ", Filterednums));
        }
    }
}
