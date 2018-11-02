using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : DeathHandler {

    override public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
