using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCastTest : MonoBehaviour
{
    public bool detectGround;

    void Update()
    {
        detectGround = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 0.1f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));
    }


}
