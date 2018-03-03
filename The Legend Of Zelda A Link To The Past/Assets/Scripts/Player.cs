using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;
    Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Walk(Vector2 velocity, bool isMoving) {
        print(velocity);
        rb.velocity = velocity;
        anim.SetFloat("FaceX", velocity.x);
        anim.SetFloat("FaceY", velocity.y);
        anim.SetBool("isMoving", isMoving);
    }

}
