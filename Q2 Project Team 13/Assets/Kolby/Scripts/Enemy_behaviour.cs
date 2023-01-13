using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behaviour : MonoBehaviour
{
    #region Public Variables
    public Transform rayCast;
    public LayerMask raycastMask;
    public float rayCastLength;
    public float attackDistance; //Minimum distance for attack
    public float moveSpeed;
    public float timer; //Attack Cooldown
    #endregion

    #region Private Variables
    private RaycastHit2D Hit;
    private GameObject Target;
    private Animator anim;
    private float distance; //Store the distance between enemy and player
    private bool attackMode;
    private bool inRange; //Check if Player is in range
    private bool cooling; // check if Enemy is cooling after attack
    private float intTimer;
    #endregion

    void Awake()
    {
        intTimer = timer; //Store the inital value of timer
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        if (inRange)
        {
            Hit = Physics2D.Raycast(rayCast.position, Vector2.left, rayCastLength, raycastMask);
            RaycastDebugger();
        }

        //When PLayer is detected
        if (Hit.collider != null)
        {
            EnemyLogic();
        }
        else if (Hit.collider == null)
        {
            inRange = false;
        }

        if (inRange == false)
        {
            anim.SetBool("canWalk", false);
            StopAttack();
        }
        void RaycastDebugger()
        {
            if (distance > attackDistance)
            {
                Debug.DrawRay(rayCast.position, Vector2.left * rayCastLength, Color.red);
            }
            else if (attackDistance > distance)
            {
                Debug.DrawRay(rayCast.position, Vector2.left * rayCastLength, Color.green);
            }
        }
     
    }

    private void EnemyLogic()
    {
        throw new NotImplementedException();
    }

    void StopAttack()
    {
        cooling = false;
        attackMode = false;
        anim.SetBool("Attack", false);
    }

    void Move()
    {
        anim.SetBool("canWalk", true);

        if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Skel_attack"))
        {
            Vector2 targetPosition = new Vector2(Target.transform.position.x, transform.position.y);

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

    void Attack()
    {
        timer = intTimer; //Reset TImer when Player Enters attack range
        attackMode = true; // check if enemy has ABIlITAY to attack or not

        anim.SetBool("canWalk", false);
        anim.SetBool("Attack", true);
    }
   

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Player")
        {
            Target = trig.gameObject;
            inRange = true;
        }

        void EnemyLogic()
        {
            {
                distance = Vector2.Distance(transform.position, Target.transform.position);
                if (distance > attackDistance)
                {
                    Move();
                    StopAttack();
                }
                else if (attackDistance >= distance && cooling == false)
                {
                    
                }

                if (cooling)
                {
                    anim.SetBool("Attack", false);
                }
            }

        }
    }

   
}