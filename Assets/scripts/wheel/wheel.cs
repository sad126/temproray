using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;


public class wheel : MonoBehaviour
{
    public float deg = 0;
    public float degInc = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(deg, 0, 0));
        deg += degInc;
    }
}
