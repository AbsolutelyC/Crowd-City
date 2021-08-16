using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dummy : MonoBehaviour
{
	public Renderer rend;
	public Leader leader = null;
	public NavMeshAgent agent;

	//public Animator animator;

	private void Update()
	{
		if (leader != null)
		{
			agent.destination = leader.transform.position;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Leader"))
		{
			Leader collideLeader = other.GetComponent<Leader>();

			if (IsOurLeaderHasFewerDummyThan(collideLeader))
			{
				if (leader != null)
					leader.RemoveDummy(this);

				collideLeader.AddDummy(this);
			}
		}
		else if (other.CompareTag("Dummy"))
		{
			Dummy collideDummy = other.GetComponent<Dummy>();

			// Compare leader
			if (leader == collideDummy.leader)
				return;

			if (leader == null)
			{
				collideDummy.leader.AddDummy(this);
			}
			else if (collideDummy.leader == null)
			{
				leader.AddDummy(collideDummy);
			}
			else if (IsOurLeaderHasFewerDummyThan(collideDummy.leader))
			{
				leader.RemoveDummy(this);
				collideDummy.leader.AddDummy(this);
			}
			else
			{
				collideDummy.leader.RemoveDummy(collideDummy);
				leader.AddDummy(collideDummy);
			}
		}
	}

	public bool IsOurLeaderHasFewerDummyThan(Leader ld)
	{
		if (leader == null)
		{
			return true;
		}
		else
		{
			return leader.dummies.Count < ld.dummies.Count;
		}
	}
}
