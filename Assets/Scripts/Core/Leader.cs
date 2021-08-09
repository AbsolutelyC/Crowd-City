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
		dum.rend.sharedMaterial = mat;

		dummies.Add(dum);
	}

	public void RemoveDummy(Dummy dum)
	{
		dummies.Remove(dum);
	}
}
