using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.position + offset;
    }
}
