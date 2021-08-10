using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject npcWalker;
    public int walkerCount = 0;
    public int xPos;
    public int zPos;
    void Start()
    {
        SpawnWalker();
        StartCoroutine(ContinueSpawn());
    }

    IEnumerator ContinueSpawn()
    {
        while(walkerCount < 300)
        {
            xPos = Random.Range(-125, 125);
            zPos = Random.Range(-125, 125);
            Instantiate(npcWalker, new Vector3(xPos, 1, zPos), Quaternion.identity,this.transform);
            yield return new WaitForSeconds(0.1f);
            walkerCount++;
        }
    }
    private void SpawnWalker()
    {
        while (walkerCount < 150)
        {
            xPos = Random.Range(-125, 125);
            zPos = Random.Range(-125, 125);
            Instantiate(npcWalker, new Vector3(xPos, 1, zPos), Quaternion.identity, this.transform);
            walkerCount++;
        }

    }


}
