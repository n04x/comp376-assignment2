using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2D2PowerUp : MonoBehaviour {
Rigidbody2D r2d2rgbd2D;
	public float speed;
	// Use this for initialization
	void Start () {
		r2d2rgbd2D = GetComponent<Rigidbody2D>();
		r2d2rgbd2D.velocity = transform.up * speed;		
	}
	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.tag == "Boundary") {
			return;
		}
		Debug.Log(other.tag);
		Destroy(gameObject);
	}
}
