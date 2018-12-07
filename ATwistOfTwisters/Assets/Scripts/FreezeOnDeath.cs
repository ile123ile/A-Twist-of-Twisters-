using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOnDeath : DeathHandler {

	private Rigidbody rb;

	public void Start()
	{
		rb = gameObject.GetComponent<Rigidbody>();
	}

	override public void Die()
    {
    	rb.constraints = RigidbodyConstraints.FreezeAll;
    }

}
