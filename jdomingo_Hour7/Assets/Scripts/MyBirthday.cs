using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{

    int birthMonth = 12;
    int birthDay = 28;

    // Start is called before the first frame update
    void Start()
    {
        for (int i= 1; i <= birthMonth; i++)
        {
            Debug.Log("Birth Month: " + i);
            if (i == 2)
                {
                    for (int j = 1; j <= birthDay; j++)
                {
                    Debug.Log("Birth Day: " + j);
                    if (j == 11)
                    {
                        Debug.Log("IT'S MY BIRTHDAY :D!!!");
                    }
                }

                }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
