using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        while (count < 20){
            int num = Random.Range(1, 21);
            if(num == 5){
                continue;
            }
            Debug.Log(num);
            if(num == 15){
                break;
            }
            count++;
        }
    }

    
   
}
