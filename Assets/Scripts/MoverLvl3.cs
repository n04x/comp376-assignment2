using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLvl3 : MonoBehaviour {
	Rigidbody2D bRigidbody2D;
	public float speed;
	public float direction;
	// Use this for initialization
	void Start () {
		// bRigidbody2D = GetComponent<Rigidbody2D>();
		// bRigidbody2D.velocity = transform.up * speed;		
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Translate (direction * Vector2.right * speed * Time.deltaTime);
		 Debug.Log(direction * Vector2.right * speed * Time.deltaTime);
	}
}
