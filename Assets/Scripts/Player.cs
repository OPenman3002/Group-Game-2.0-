using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidBody;
    private Animator anim;
    [SerializeField]
    private float MovementSpeed;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        Debug.Log(vertical);
        Debug.Log(horizontal);
        HandleMovement(horizontal, vertical);

        
    }
    private void HandleMovement(float horizontal, float vertical)
    {
        myRigidBody.velocity = new Vector2(horizontal * MovementSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, vertical * MovementSpeed);

        if (vertical == 0 && horizontal == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
        }
        if ( horizontal >= 1 || horizontal >=1 && vertical <= 1 || horizontal >=1 && vertical >= 1)
        {
            GetComponent<Animator>().SetBool("Right", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Right", false);
        }
        if (horizontal <= -1 || horizontal <= -1 && vertical <= 1 || horizontal <= -1 && vertical >= 1)
        {
            GetComponent<Animator>().SetBool("Left", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Left", false);
        }
        if (horizontal >= 1 || horizontal >= 1 && vertical <= 1 || horizontal >= 1 && vertical >= 1)
        {
            GetComponent<Animator>().SetBool("Right", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Right", false);
        }
        if (vertical <= -1)
        {
            GetComponent<Animator>().SetBool("Down", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Down", false);
        }
        if (vertical >= 1)
        {
            GetComponent<Animator>().SetBool("Up", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Up", false);
        }
    }
}
