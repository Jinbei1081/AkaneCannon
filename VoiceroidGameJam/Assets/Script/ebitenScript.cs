using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ebitenScript : MonoBehaviour
{

    public float power = 0;

    GameObject Akane;

	// Use this for initialization
	void Start () {

        Akane = GameObject.Find("棒アカネ");
        transform.position = new Vector3(Akane.transform.position.x + 50, Random.Range(0, 15));
        transform.parent = GameObject.Find("エビ天").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x - Akane.transform.position.x <= -50)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.GetComponent<AkaneScript>().GetTouchFlore()) { return; }
            Rigidbody2D rigidbody;
            rigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(collision.transform.TransformDirection(Vector3.up) * power, ForceMode2D.Impulse);
            Akane.GetComponent<AkaneSound>().PlayEatSouud();
            Destroy(gameObject);
        }
    }
}
