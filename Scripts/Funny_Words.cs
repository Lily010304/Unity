using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Funny_Words : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        string random_words = "";

        int last = 0;
        while (last < 7)
        {
            int randomIndex = UnityEngine.Random.Range(0, words.Length);
            
            random_words += words[randomIndex] + " " ;
        }

        Debug.Log(random_words);
    }

   
}
