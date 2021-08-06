using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    public Material[] material;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            agent.destination = target.transform.position;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = other.gameObject;
        }
        else if (other.CompareTag("NPC") && gameObject.GetComponent<Renderer>().material == material[0])
        {
            other.gameObject.GetComponent<Renderer>().material = material[0];
        }
        else if (other.CompareTag("Leader"))
        {
            target = other.gameObject;
            

        }
        else if (other.CompareTag("Leader1"))
        {
            target = other.gameObject;
            
        }
        else if (other.CompareTag("Leader2"))
        {
            target = other.gameObject;
            
        }
        else if (other.CompareTag("Leader3"))
        {
            target = other.gameObject;
            
        }
        else if (other.CompareTag("Leader4"))
        {
            target = other.gameObject;
            
        }

    }

}
