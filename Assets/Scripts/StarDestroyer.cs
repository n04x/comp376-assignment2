using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDestroyer : MonoBehaviour {
	Rigidbody2D sdrgb2d;
	public float speed;
	// true mean it go to right, false go to left.
	bool direction = true;
	// Use this for initialization
	void Start () {
		sdrgb2d = GetComponent<Rigidbody2D>();
		sdrgb2d.velocity = transform.right * speed;		
		
	}
	
	// Update is called once per frame
	void Update () {

		// if(transform.position.x >= 8) {
		// 	direction = false;
		// } else if(transform.position.x <= -8) {
		// 	direction = true;
		// }
		// if(direction) {
		// 	sdrgb2d.velocity = transform.right * speed;		
		// } else {
		// 	sdrgb2d.velocity = -transform.right * speed;
		// }
	}
}
