using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyOfWallCliming : MonoBehaviour
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

    // Update is called once per frame



    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.tag);
        if (collision.tag == "Wall")
        {
            Debug.Log("In wall...");

            if (Input.GetKey(KeyCode.W))
            {
                //Debug.Log("WWWWWWWWWWWWWWWWWWWWWWWWW");
                if (Input.GetAxis("Vertical") > 0)
                {
                    sr.flipY = false;
                    rb2.AddForce(new Vector2(0, accel));
                }
                if (Input.GetAxis("Vertical") < 0)
                {
                    sr.flipY = true;
                    rb2.AddForce(new Vector2(0, -accel));
                }
            }
            a.SetBool("Wall", true);

        }
        else
        {

            a.SetBool("Wall", false);
        }
    }


    private void FixedUpdate()
    {
        float vertiValue = Input.GetAxis("Vertical");

        if (vertiValue == 0)
        {

            a.SetBool("Climbing", false);

        }
        else
        {

            a.SetBool("Climbing", true);

        }

    }
}
