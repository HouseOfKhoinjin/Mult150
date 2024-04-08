using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objectYouWant;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
        {
            objectYouWant.transform.Rotate(0f, myVal, 0f);
        }
        if (myVal != 0)
        {
            objectYouWant.transform.Rotate(mxVal, 0f, 0f);
        }
    }
}
