using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    //horizontal movement
    float horizontalMove;
    float verticalMove;
    public float speed = 3f;

    //rigid body
    Rigidbody2D myBody;

    //animator
    Animator myAnim;

    //sprite renderer
    SpriteRenderer myRend;

    //access game manager
    public GameManager gameManager;

    //access teleport object
    public GameObject Teleport;

    // Start is called before the first frame update
    void Start()
    {
        //gets components
        myBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        myRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(verticalMove);
        //horizontal movement (A&D, left&right)
        horizontalMove = Input.GetAxis("Horizontal");

        //vertical movement (W&S, up&down)
        verticalMove = Input.GetAxis("Vertical");

        //if horizontal movement is happening to the right
        if (horizontalMove > 0.1f)
        {
            //walking animation boolean is true
            myAnim.SetBool("WalkHorizontal", true);
            //do not flip the x to face right
            myRend.flipX = true;
        }
        //if horizontal movement is happening to the left 
        else if (horizontalMove < -0.1f)
        {
            //walking horizontal animation boolean is true
            myAnim.SetBool("WalkHorizontal", true);
            //flip the x to face left
            myRend.flipX = false;
        }
        //if not moving horizontal
        else
        {
            //walking horizontal animation boolean is false
            myAnim.SetBool("WalkHorizontal", false);
        }

        //if vertical movement is happening upwards
        if (verticalMove > 0.1f)
        {
            //walking up animation boolean is true
            myAnim.SetBool("WalkUp", true);
        }
        //if not moving up
        else
        {
            //walking up animation boolean is false
            myAnim.SetBool("WalkUp", false);

        }
        //if vertical movement is happening downwards
        if (verticalMove < -0.1f)
        {
            //walking down animation boolean is true
            myAnim.SetBool("WalkDown", true);

        }
        //if not moving down
        else
        {
           //walking down animation boolean is false
           myAnim.SetBool("WalkDown", false);

        }
    }

    void FixedUpdate()
    {
        //set movespeed to horizontal move float times speed
        float horizontalSpeed = horizontalMove * speed;

        float verticalSpeed = verticalMove * speed;

        //set velocity to set velocity
        myBody.velocity = new Vector3(horizontalSpeed, verticalSpeed, 0f);
    }

    //if colliding
    void OnCollisionEnter2D(Collision2D collision)
    {
        //with teleport obj
        if (collision.gameObject.name == "Exit")
        {
            //trigger game manager teleport function
            gameManager.Teleport();
        }
    }
}
