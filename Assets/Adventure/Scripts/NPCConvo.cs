using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCConvo : MonoBehaviour
{
    //audio
    public AudioSource meowSource;
    public AudioClip meowSound;

    //public string dialogue
    public string myDialogue;

    //access TMP
    public GameObject textObject;
    public TMP_Text speechUI;

    void OnCollisionEnter2D(Collision2D col)
    {
        //if colliding with player
        if(col.gameObject.name == "Player")
        {
            meowSource.PlayOneShot(meowSound);
            //make text visible
            textObject.SetActive(true);
            //change text to public string
            speechUI.text = myDialogue;
        }
    }

    //if stopping collision
    void OnCollisionExit2D(Collision2D col)
    {
        //turn off text 
        textObject.SetActive(false);
    }

}
