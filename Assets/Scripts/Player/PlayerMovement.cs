using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed;

    private CharacterController controller;
    private Vector3 direction;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        PlayerMove();
        
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }

    private void PlayerMove()
    {
        if (SwipeManager.swipeUp)
        {
            direction.x = 0;
            direction.z = forwardSpeed;
        }
        else if (SwipeManager.swipeRight)
        {
            direction.z = 0;
            direction.x = forwardSpeed;
        }
        else if (SwipeManager.swipeLeft)
        {
            direction.z = 0;
            direction.x = -forwardSpeed;
        }
        else if (SwipeManager.swipeDown)
        {
            direction.x = 0;
            direction.z = -forwardSpeed;
        }
    }
}
