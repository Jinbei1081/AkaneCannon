using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAkane : MonoBehaviour {

    public GameObject Akane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Akane.transform.position.x, 8.0f, -10);
	}
}
