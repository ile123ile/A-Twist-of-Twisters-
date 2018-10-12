using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {
    public float speed = 1;
    public float dirChangeTime;
    private Vector3 direction;
    private float timeLeft;
    private Rigidbody rb;

    void Start()
    {
        timeLeft = 0;
        rb = gameObject.GetComponent<Rigidbody>();
    }

	void FixedUpdate () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = dirChangeTime;
            direction = new Vector3(Random.Range(0,100)-50,0,Random.Range(0,100)-50);
            direction = Vector3.Normalize(direction);
        }

        rb.AddForce(speed * direction);
	}
}
