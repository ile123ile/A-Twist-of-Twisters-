using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour {

    public float deathHeight;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (transform.position.y < deathHeight)
        {
            DeathHandler.HandleDeath(gameObject);
        }
    }
}
