using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// <image url="E:\GameJam\VOICEROID GameJamProj/icon.png" />

public class AkaneScript : MonoBehaviour
{
    public float power;
    public float up;
    public float back;

    private int stage;
    private float duraltion;

    private bool isfloarTouch;
    private bool isCreateUI;

    public static float distance;

    new Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        duraltion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) return;

        duraltion += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            OnInputDown();
        }
        else
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began)
                {
                    OnInputDown();
                }
            }
        }

        if (duraltion > 1.5f) {
            stage = 0;
            duraltion = 0;
        }


        if (rigidbody.velocity.x < -0.1f)
        {
            rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
        }

        if (transform.position.y >= 20)
        {
            float ypos = transform.position.y;
            ypos = 20;
            transform.position = new Vector3(transform.position.x, ypos);
        }

        distance = transform.position.x;
    }

    private void OnInputDown()
    {
        Debug.Log("OnInputDown");
        if (transform.position.x <= 1)
        {
            rigidbody.constraints = RigidbodyConstraints2D.None;
            rigidbody.AddForce(transform.TransformDirection(Vector3.up) * power, ForceMode2D.Impulse);

        }
        else
        {
            if (!isfloarTouch)
            {
                if (duraltion > 0.5)
                {
                    GetComponent<AkaneSound>().PlayJumpSound(stage);
                    stage++;
                    if (stage > 2) stage = 0;
                    Debug.Log(stage);
                    duraltion = 0;
                }
                rigidbody.AddForce(new Vector3(back, up), ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AkaneSound>().PlayLandingSouud();
        rigidbody.constraints = RigidbodyConstraints2D.None;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isfloarTouch = true;
        if (rigidbody.velocity.x < 0.5f&& isCreateUI==false)
        {
            SceneManager.LoadScene("ResultUI", LoadSceneMode.Additive);
            isCreateUI = true;
        }
    }

    public bool GetTouchFlore()
    {
        return isfloarTouch;
    }

}
