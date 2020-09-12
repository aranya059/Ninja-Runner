using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce = 6f;
    public float forwardForce = 0f;
    private Rigidbody2D myRB;
    private Animator anim;
    private bool canJump;
    
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        canJump = true;
        anim = GetComponent<Animator>();
        //
        //
    }

    // Update is called once per frame
    public void jump()
    {
        if(canJump)
        {
            canJump = false;
            anim.SetBool("isJumping", true);
            anim.SetBool("isRunning", false);
            if(transform.position.x<0)
            {
                forwardForce = 1.5f;
            }
            else
            {
                forwardForce = 0f;
            }
            myRB.velocity = new Vector2(forwardForce, jumpForce);
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;
        anim.SetBool("isRunning", true);
        anim.SetBool("isJumping", false);
    }

}
