using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkaneSound : MonoBehaviour {

    public AudioClip shout;
    public AudioClip auch;

    public AudioClip[] eat=new AudioClip[3];
    public AudioClip[] jump=new AudioClip[3];

    int stage;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && transform.position.x<=1)
        {
            audioSource.clip = shout;
            audioSource.Play();
        }
       
    }

    public void PlayEatSouud()
    {
        audioSource.clip = eat[Random.Range(0,3)];
        audioSource.Play();
    }

    public void PlayJumpSound(int _stage)
    {
        audioSource.clip = jump[_stage];
        audioSource.Play();

    }

    public void PlayLandingSouud()
    {
        audioSource.clip = auch;
        audioSource.Play();
    }
}
