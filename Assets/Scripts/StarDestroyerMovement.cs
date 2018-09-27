using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDestroyerMovement : MonoBehaviour {
	public float speedY;
	public float distance;
	public float speedX;
	Rigidbody2D ssrgb2d;
	
	private Vector3 _startPos; 
	void Start() {
		ssrgb2d = GetComponent<Rigidbody2D>();
		ssrgb2d.velocity = transform.right * speedX;
		_startPos = transform.position;
	}
	// Update is called once per frame
	void Update () {
		Vector3 y_movement = new Vector3(transform.position.x, Mathf.Sin(speedY * Time.time) * distance, transform.position.z);
		transform.position = _startPos + y_movement;		
	}
}
