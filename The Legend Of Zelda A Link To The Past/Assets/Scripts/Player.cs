using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rb;
    private Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}


    // Command Methods


    /// <summary>
    /// Walk player with velocity.
    /// </summary>
    /// <returns>Void.</returns>
    /// <param name="velocity">Velocity of the player.</param>
    public void Walk(Vector2 velocity) {
        rb.velocity = velocity;
        anim.SetFloat("FaceX", velocity.x);
        anim.SetFloat("FaceY", velocity.y);
        anim.SetBool("isMoving", !velocity.Equals(Vector2.zero));
    }

    /// <summary>
    /// Executes the attack.
    /// </summary>
    public void Attack() {
        anim.SetTrigger("Attacking");
    }

}
