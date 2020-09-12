using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlide : MonoBehaviour
{
    public float slideForce = 5f;
    //private Rigidbody2D myRB;
    private Animator anim;
    private bool canSlide;

    void Start()
    {
        //myRB = GetComponent<Rigidbody2D>();
        canSlide = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void slide()
    {
        if (canSlide)
        {
            canSlide = false;
            anim.SetBool("isSliding", true);
            anim.SetBool("isRunning", false);
            StartCoroutine(run());
            //myRB.velocity = new Vector2(0f, slideForce);

        }

    }
    /*private void OnCollisionEnter2D(Collision2D other)
    {
        canSlide = true;
        anim.SetBool("isRunning", true);
        anim.SetBool("isSliding", false);
    }*/
    public IEnumerator run()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("isRunning", true);
        anim.SetBool("isSliding", false);
        canSlide = true;
    }

}
