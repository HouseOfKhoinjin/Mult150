using UnityEngine;
using System.Collections;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    int lamps = 0;

    void Start()
    {
        transform.position = new Vector3(0f, 0.5f, -5f);
        for (int count = 1; count < 11; count++)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(1f, 1f, -5f);
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
