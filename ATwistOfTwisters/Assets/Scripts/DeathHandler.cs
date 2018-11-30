using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour {

    public bool dead = false;

    public void AttemptDeath()
    {
        if(!dead)
        {
            Die();
            dead = true;
        }
    }

	public virtual void Die()
    {
    }

    public static void HandleDeath(GameObject obj)
    {
        DeathHandler[] deaths = obj.GetComponents<DeathHandler>();
        foreach(DeathHandler death in deaths)
        {
            death.AttemptDeath();
        }
    }
}
