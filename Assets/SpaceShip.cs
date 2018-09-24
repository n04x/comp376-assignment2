using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {
	
	public float speed;
	private float limitX = 6;
	private float limitY = 4;
	Rigidbody2D ssRigidbody;
	// Use this for initialization
	void Start () {
		ssRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(horizontal, vertical);
		
		ssRigidbody.velocity = movement * speed;

		ssRigidbody.position = new Vector3(
			Mathf.Clamp(ssRigidbody.position.x, -limitX, limitX), 
			Mathf.Clamp(ssRigidbody.position.y, -limitY, limitY),
			0.0f
		);
	}
}
