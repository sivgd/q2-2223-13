using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour
{
    public RaycastHit2D rhit;
    void Update()
    {
        //Detects in any layer... infinitely... to player's right (even if rotated)
        rhit = Physics2D.Raycast(transform.position, transform.right);

        //Detects if Enemy is to player's right (even if rotated)
        //rhit = Physics2D.Raycast(transform.position,transform.right ,100f,LayerMask.GetMask("Enemy"));

        //Detects only to the right
        //rhit = Physics2D.Raycast(transform.position, Vector2.right, 100f, LayerMask.GetMask("Enemy"));

        if (rhit.collider != null)
        {
            Debug.Log(rhit.collider.gameObject.name);
            rhit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            Debug.Log("----");
        }
    }
}
