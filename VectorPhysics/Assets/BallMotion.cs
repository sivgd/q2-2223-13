using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{

    public float initVX;
    public float initVY;

    public float currentVX;
    public float currentVY;

    public string ColliderInfo;

    public string info1;
   public  string info2;

    Vector2 velocityVector;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocityVector = new Vector2(initVX, initVY);
        rb.velocity = velocityVector;
    }

    // Update is called once per frame
    void Update()
    {
        currentVX = rb.velocity.x;
        currentVY = rb.velocity.y;
        float magnitude = rb.velocity.magnitude;
        float angle = Mathf.Atan2(currentVY, currentVX) * Mathf.Rad2Deg; 
        info1 = "V: " + rb.velocity.ToString() + "Mag: " + magnitude + "Angle: " + angle;



        Vector2 unitVector = rb.velocity.normalized;
        info2 = "unitVector : (" + unitVector.x + "," + unitVector.y + ")";

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        ColliderInfo = collision.collider.name;
    }


}


