using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;
    public float jumpForce;
    private Rigidbody rb;
    private bool isGrounded;
    public float sqrMaxVelocity;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

   
        if (rb.velocity.sqrMagnitude < sqrMaxVelocity)
        {
            rb.AddForce(movement * speed);
        }
     


        if (Input.GetKeyDown("space") && isGrounded == true){
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Platform")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Platform")
        {
            isGrounded = false;
        }
    }

}
