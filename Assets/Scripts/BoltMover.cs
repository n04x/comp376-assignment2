using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMover : MonoBehaviour {
	Rigidbody2D bRigidbody2D;
	public float speed;
	// Use this for initialization
	void Start () {
		bRigidbody2D = GetComponent<Rigidbody2D>();
		bRigidbody2D.velocity = transform.up * speed;		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
