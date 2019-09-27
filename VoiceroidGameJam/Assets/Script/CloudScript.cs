using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{

    public GameObject Akane;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.02f, 0, 0);

        if (transform.position.x - Akane.transform.position.x <= -45)
        {
            transform.position += new Vector3(80, 0, 0);
        }
    }
}
