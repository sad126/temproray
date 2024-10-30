using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = {"Cat", "Dog", "Car",
         "Pizza", "Hat", "Fish", "Tree",
        "Monkey", "Ball", "Bird"};
        int count = 0;
        string funnyScentense = "";
        while(count < 7){
            int random = Random.Range(0, words.Length);
            string item = words[random];
            funnyScentense += item + " ";
            count++;
        }
        Debug.Log(funnyScentense);
        
    }

   
}
