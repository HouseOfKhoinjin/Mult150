using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0f, -.1f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0f, .1f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-.1f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(.1f, 0f, 0f);
        }
    }
}
