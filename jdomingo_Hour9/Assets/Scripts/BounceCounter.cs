using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{

    public int BouncyCount;
    public int bounce;
    
    // Start is called before the first frame update
    void Start()
    {
         bounce = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        BouncyCount = bounce++;
        print("The ball has bounced this many times: " + BouncyCount);
    }
}
