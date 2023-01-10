//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Enemy_behaviour : MonoBehaviour
//{
//    #region Public Variables
//    public Transform rayCast;
//    public LayerMask raycastMask;
//    public float rayCastLength; 
//    public float attackDistance; //Minimum distance for attack
//    public float moveSpeed;
//    public float timer; //Attack Cooldown
//    #endregion

//    #region Private Variables
//    private RaycastHit2D Hit;
//    private GameObject Target;
//    private Animator anim;
//    private float distance; //Store the distance between enemy and player
//    private bool attackMode;
//    private bool inRange; //Check if Player is in range
//    private bool cooling; // check if Enemy is cooling after attack
//    private float intTimer;
//    #endregion

//    void Awake()
//    {
//        intTimer = timer; //Store the inital value of timer
//        anim = GetComponent<Animator>();
//    }

//    void Update()
//    {
//        if (inRange)
//        {
//            hit = Physics2D.Raycast(rayCast.position, Vector2.left, rayCastLength, raycastMask);
//            RaycastDebugger();
//        }

//        //When PLayer is detected
//        if(hit.collider != null)
//        {
//            EnemyLogic();
//        }
//        else if(Hit.collider == null)
//        {
//            inRange = false;
//        }
//    }

//    void OnTriggerEnter2D (Collider2D trig)
//    {
//        if(trig.gameObject.tag == "Player")
//        {
//            Target = trig.gameObject;
//            inRange = true;
//        }
        
//        void RaycastDebugger()
//        {
//            if(distance > attackDistance)
//            {
//                Debug.DrawRay(rayCast.position, Vector2.left * rayCastLength, Color.red);
//            }
//            else if(attackDistance > distance)
//            {
//                Debug.DrawRay(rayCast.position, Vector2.left * rayCastLength, Color.green);
//            }
//        }
//    }
//}
