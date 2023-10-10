using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    //horizontal movement
    float horizontalMove;
    float verticalMove;
    public float moveSpeed = 3f;

    //animator
    Animator myAnim;

    //sprite renderer
    SpriteRenderer myRend;

    // Start is called before the first frame update
    void Start()
    {
        //gets components
        myAnim = GetComponent<Animator>();
        myRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        //if up arrow or W key is pressed
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //walking up animation boolean is true
            myAnim.SetBool("WalkUp", true);
            //move y pos up
            newPos.y += Time.deltaTime * moveSpeed;
        }
        else
        {
            //walking up animation boolean is false
            myAnim.SetBool("WalkUp", false);
        }


        //if vertical movement is happening downwards
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //walking down animation boolean is true
            myAnim.SetBool("WalkDown", true);
            //move y pos down
            newPos.y -= Time.deltaTime * moveSpeed;
        }
        //if not moving down
        else
        {
            //walking down animation boolean is false
            myAnim.SetBool("WalkDown", false);

        }

        //if horizontal movement is happening to the right
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //walking animation boolean is true
            myAnim.SetBool("WalkHorizontal", true);
            //do not flip the x to face right
            myRend.flipX = true;
            //move x pos right
            newPos.x += Time.deltaTime * moveSpeed;
        }
        //if horizontal movement is happening to the left 
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //walking horizontal animation boolean is true
            myAnim.SetBool("WalkHorizontal", true);
            //flip the x to face left
            myRend.flipX = false;
            //move x pos left
            newPos.x -= Time.deltaTime * moveSpeed;
        }
        //if not moving horizontal
        else
        {
            //walking horizontal animation boolean is false
            myAnim.SetBool("WalkHorizontal", false);
        }

        transform.position = newPos;
    }
}
