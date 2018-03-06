using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private bool isInContact;
    private Rigidbody2D rb;
    private Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isInContact = false;
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
    /// Executes the Attack.
    /// </summary>
    /// <returns>Void.</returns>
    /// <param name="velocity">Velocity of the player.</param>
    public void Attack(Vector2 velocity) {
        anim.SetFloat("FaceX", velocity.x);
        anim.SetFloat("FaceY", velocity.y);
        anim.SetTrigger("Attacking");
    }


    /// <summary>
    /// Grab a object.
    /// </summary>
    /// <returns>Void.</returns>
    /// <param name="velocity">Velocity of the player.</param>
    public void Grab(Vector2 velocity) {
        if (isInContact) {
            print("Carrying");
        }

        anim.SetFloat("FaceX", velocity.x);
        anim.SetFloat("FaceY", velocity.y);
        anim.SetBool("isCarrying", isInContact);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //if (collision.o)
    }
}
