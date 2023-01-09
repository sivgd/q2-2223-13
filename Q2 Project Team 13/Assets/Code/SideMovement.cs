using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SideMovement : MonoBehaviour
{
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        a = gameObject.GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        float horizValue = Input.GetAxis("Horizontal");

        if(horizValue == 0)
        {

            a.SetBool("Moving", false);

        }
        else
        {

            a.SetBool("Moving", true);

        }
        //Move right
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
            rb2.AddForce(new Vector2(accel, 0));

        }

        //Move left
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(-accel, 0));

        }
    }
}
