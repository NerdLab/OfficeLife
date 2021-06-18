using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMovement : MonoBehaviour {

    public float MoveTime = 1f;
    public LayerMask PlayerLayer;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private float inverseMoveTime;

	// Use this for initialization
    // protected virtual void for classes that need to override the behaviour of this baseclass
	protected virtual void  Start () {

        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / MoveTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
