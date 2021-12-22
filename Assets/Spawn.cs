using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; ++i)
        {
            Vector3 p = Vector3.zero;
            p.x = Random.Range(-5.0f, 5.0f);
            p.y = Random.Range(-5.0f, 5.0f);
            Instantiate(prefab, p, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
