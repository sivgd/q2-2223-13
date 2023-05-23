using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private Controls controls;
    public UnityEvent<Vector2> move;
    void OnEnable()
    {
        controls.Enable();
    }
     void OnDisable()
    {
        controls.Disable();
    }
    // Start is called before the first frame update
    void Awake()
    {
        controls = new Controls();
    }

    // Update is called once per frame
    void Update()
    {
        move.Invoke(controls.Player.Move.ReadValue<Vector2>()* 10);
    }
}
