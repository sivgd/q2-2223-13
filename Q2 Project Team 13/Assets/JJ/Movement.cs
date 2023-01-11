using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {

        //Move right
        if (Input.GetAxis("Horizontal") > 0)
        {
            //sr.flipX = false;
            this.transform.localScale = new Vector3(1, 1, 1);
            
            rb2.AddForce(new Vector2(accel, 0));
        }

        //Move left
        if (Input.GetAxis("Horizontal") < 0)
        {
            //sr.flipX = true;
            this.transform.localScale = new Vector3(-1, 1, 1);
            rb2.AddForce(new Vector2(-accel, 0));
        }



    }
}