using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float turnSpeed = 20f;
    public VariableJoystick variableJoystick;

    Animator animator;
    Quaternion m_Rotation = Quaternion.identity;

    private void Awake()
    {
        variableJoystick.SetMode(JoystickType.Floating);
        animator = GetComponent<Animator>();
    }
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        transform.position += direction * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
        if (direction != Vector3.zero)
        {
            animator.SetBool("isRunning", true);
        }
    }
}