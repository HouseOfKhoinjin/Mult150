using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    // Start is called before the first frame update

    Light lightComponent;

    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.L))
        {
            lightComponent.enabled = false;
        }
    }
}
