using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtManager : MonoBehaviour {

    public Sprite idle;
    public Sprite falling;
    public float moveThreshold;

    private Rigidbody rb;
    private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = idle;
	}
	
	// Update is called once per frame
	void Update () {
		if(rb.velocity.y < -moveThreshold)
        {
            sr.sprite = falling;
        }
        else if (Mathf.Abs(rb.velocity.y) <= moveThreshold)
        {
            sr.sprite = idle;
        }
	}
}
