using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{
    public Rigidbody2D armBoby;
    Rigidbody2D mainBoby;

    public float power;
    public AudioSource mySource;
    public AudioClip jumpClip;

    // Start is called before the first frame update
    void Start()
    {
        //mySource.clip = jumpClip;
        //mySource.Play();

       //mySource.PlayOneShot(jumpClip);//play one time and remove the file after
        mainBoby = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //mySource.PlayOneShot(jumpClip);
            mySource.clip = jumpClip;
            mySource.Play();
            armBoby.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            mainBoby.velocity = new Vector3(0, power, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            mainBoby.velocity = new Vector3(0, -power, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            mainBoby.velocity = new Vector3(-power, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            mainBoby.velocity = new Vector3(power, 0, 0);
        }
    }
}
