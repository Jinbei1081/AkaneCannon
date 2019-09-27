using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasureDistance : MonoBehaviour {

    public GameObject Akane;
    private Text tex;

	// Use this for initialization
	void Start () {
        tex = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        tex.text = "飛距離：" + (int)Akane.transform.position.x + "Ｍ";
	}
}
