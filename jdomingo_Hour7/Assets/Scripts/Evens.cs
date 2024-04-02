using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{

    int evenNumber = 101;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 22; i < evenNumber; i+= 2)
        {            
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
