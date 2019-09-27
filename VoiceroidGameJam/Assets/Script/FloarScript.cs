using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloarScript : MonoBehaviour {

    public GameObject Akane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x - Akane.transform.position.x <= -42){
            transform.position += new Vector3(80, 0, 0);
        }
	}
}
