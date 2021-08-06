using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountFollower : MonoBehaviour
{
    public List<GameObject> playerFollow = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            if (!playerFollow.Contains(other.gameObject))
            {
                playerFollow.Add(other.gameObject);
            }
        }
    }
    private void Update()
    {
        Debug.Log("PlayerScore:" + playerFollow.Count);
    }
}
