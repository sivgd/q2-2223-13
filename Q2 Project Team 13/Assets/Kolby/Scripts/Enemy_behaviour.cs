using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behaviour : MonoBehaviour
{
    #region Public Variables
    public Transform rayCast;
    public LayerMask raycastMask;
    public float rayCastLength; //Minimum distance for attack
    public float moveSpeed;
    public float timer; //Attack Cooldown
    #endregion

    #region Private Variables
    private RaycastHit2D Hit;
    private GameObject Target;
    private Animator anim;
    private float distance; //Store the distance between enemy and player
    private bool attackMode;
    #endregion
    // Update is called once per frame
    void Update()
    {
        
    }
}
