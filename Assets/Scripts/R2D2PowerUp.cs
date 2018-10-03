using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R2D2PowerUp : MonoBehaviour {
	Rigidbody2D r2d2rgbd2D;
	public float speed;
	private SpaceShip space_ship;
	// Use this for initialization
	void Start () {
		GameObject space_ship_object = GameObject.FindWithTag("Player");
		space_ship = space_ship_object.GetComponent<SpaceShip>();
		r2d2rgbd2D = GetComponent<Rigidbody2D>();
		r2d2rgbd2D.velocity = transform.up * speed;		
	}
	void OnTriggerEnter2D(Collider2D other) {

		if(other.tag == "Boundary") {
			return;
		}
		
		if(other.tag == "Player") {
			space_ship.Upgrade();
		}
		Destroy(gameObject);
	}
}
