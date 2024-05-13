using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("ColorChange");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Translate");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Rotate");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Scale");
        }
    }
}
