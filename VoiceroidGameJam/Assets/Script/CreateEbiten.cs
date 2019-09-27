using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEbiten : MonoBehaviour {

    public GameObject Ebiten;

    float nextGen = 50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (nextGen-transform.position.x<0)
        {
            Instantiate(Ebiten);
            nextGen = transform.position.x+Random.Range(80f,120f);
        }
	}
}
