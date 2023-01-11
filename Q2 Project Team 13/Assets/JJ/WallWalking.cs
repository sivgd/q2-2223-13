using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalking : MonoBehaviour
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

        }
    }


    private void Update()
    {
      
    }
}
