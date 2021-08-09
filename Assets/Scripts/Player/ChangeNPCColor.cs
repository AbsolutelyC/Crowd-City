using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNPCColor : MonoBehaviour
{
    public Material material;
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("NPC"))
        //{
        //    other.gameObject.GetComponent<Renderer>().material = material;
        //}
    }
}
