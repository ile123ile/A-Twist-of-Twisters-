using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtManager : DeathHandler {

    public Sprite idle;
    public Sprite falling;
    public Sprite deadSprite;
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
            SetSprite(falling);
        }
        else if (Mathf.Abs(rb.velocity.y) <= moveThreshold)
        {
            SetSprite(idle);
        }
        if(rb.velocity.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
	}

    public override void Die()
    {
        SetSprite(deadSprite);
    }

    private void SetSprite(Sprite sprite)
    {
        if(!dead)
        {
            sr.sprite = sprite;
        }
    }
}
