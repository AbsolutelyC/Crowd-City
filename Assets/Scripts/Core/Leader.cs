using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader : MonoBehaviour
{
	public Renderer rend;
	public List<Dummy> dummies = new List<Dummy>();
	

	private Material mat;

	private void Awake()
	{
		mat = rend.sharedMaterial;
	}

	public void AddDummy(Dummy dum)
	{
		dum.leader = this;
		//dum.animator.SetBool("isFollowing", true);
        dum.rend.sharedMaterial = mat;
		dum.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material = mat;
		dum.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = mat;

		dummies.Add(dum);
	}

	public void RemoveDummy(Dummy dum)
	{
		dummies.Remove(dum);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Leader"))
        {
			if(this.dummies.Count == 0)
            {
				Destroy(this.gameObject);
            }
        }
    }
}
