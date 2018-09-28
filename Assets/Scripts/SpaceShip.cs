using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {
	
	public float speed;
	private float HORIZONTAL_LIMIT = 6;
	private float VERTICAL_LIMIT = 4;
	Rigidbody2D ssRigidbody;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	AudioSource ssLaserSound;
	private float nextFire;
	// Use this for initialization
	void Start () {
		ssRigidbody = GetComponent<Rigidbody2D>();
		ssLaserSound = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		// instantiate our shooting of bolt.
		if(Input.GetKeyDown("space") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			ssLaserSound.Play();
		}
		// move our space ship around
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(horizontal, vertical);
		ssRigidbody.velocity = movement * speed;

		// check if the screen boundary is respected
		ssRigidbody.position = new Vector3(
			Mathf.Clamp(ssRigidbody.position.x, -HORIZONTAL_LIMIT, HORIZONTAL_LIMIT), 
			Mathf.Clamp(ssRigidbody.position.y, -VERTICAL_LIMIT, VERTICAL_LIMIT),
			0.0f	// Since the z axis will never change we set it to 0.
		);
	}
}
