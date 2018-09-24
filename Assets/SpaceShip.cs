using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {
	
	public float speed;
	private float minX = -5;
	private float maxX = 5;
	private float minY = -5;
	private float maxY = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(horizontal, vertical);
		
		GetComponent<Rigidbody2D>().velocity = movement * speed;
	}
}
