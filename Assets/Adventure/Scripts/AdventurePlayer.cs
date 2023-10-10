using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurePlayer : MonoBehaviour
{
    //keys audio
    public AudioSource keysSource;
    public AudioClip keysSound;

    //door audio
    public AudioSource doorSource;
    public AudioClip doorSound;

    //access teleport object
    public GameObject Teleport;

    //access door object
    public GameObject Door;

    //access key object
    public GameObject Key;

    //have key is not true
    bool haveKey = false;

    //access game manager
    public GameManager gameManager;

    //if colliding
    void OnCollisionEnter2D(Collision2D collision)
    {
        //with teleport obj
        if (collision.gameObject.name == "Exit")
        {
            //trigger game manager teleport function
            gameManager.Teleport();
        }

        //with key
        if (collision.gameObject.name == "Key")
        {
            //play key noise
            keysSource.PlayOneShot(keysSound);
            //turn on have key
            haveKey = true;
            //destroy key
            Destroy(Key);
        }

        //if have key and colliding with door
        if (haveKey && collision.gameObject.name == "Door")
        {
            //play door audio
            doorSource.PlayOneShot(doorSound);
            //destroy door
            Destroy(Door);
        }
    }

}
