using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float turnSpeed = 20f;
    public VariableJoystick variableJoystick;
    private Vector3 direction;

    Animator animator;

    private void Awake()
    {
        variableJoystick.SetMode(JoystickType.Floating);
        animator = GetComponent<Animator>();
    }

    public void FixedUpdate()
    {

        direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        transform.position += direction * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
        if (direction != Vector3.zero)
        {
            animator.SetBool("isRunning", true);
        }
        else animator.SetBool("isRunning", false);
    }
}