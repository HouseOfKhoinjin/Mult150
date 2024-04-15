using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTriggerLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the left rectangle");
    }

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the left rectangle");
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the left rectangle");
    }
}
