using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string words[] = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree",
        "Monkey", "Ball", "Bird"};
        int count = 7;
        string funnyScentense = "";
        while(count < 7){
            int random = Random.range(0, words.length);
            funnyScentense += words[random] + " ";
            count++;
        }
        Debug.Log(funnyScentense);
        
    }

   
}
