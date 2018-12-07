using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : DeathHandler {

    public float deathClock = 5;
    private float timeOut = -1;

    override public void Die()
    {
        timeOut = deathClock;
    }

    public void FixedUpdate()
    {
        if(timeOut > 0)
        {
            timeOut -= Time.fixedDeltaTime;
            if (timeOut <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
