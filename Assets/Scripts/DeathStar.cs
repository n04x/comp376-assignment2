using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathStar : MonoBehaviour {

	public GameObject explosion;
	float DEATHSTAR_MOVEMENT = 7.0f;
	float timer;
	bool invincible = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer < DEATHSTAR_MOVEMENT) {
			transform.Translate(-Vector2.up * Time.deltaTime);

		} else {
			invincible = false;
		}
	}

	 void OnTriggerEnter2D(Collider2D other) {
		 if(other.tag == "Shield") {
			 return;
		 }
		 if(invincible) {
			 Destroy(other.gameObject);
		 } else {
			Instantiate(explosion, transform.position, Quaternion.identity);
		 	Destroy(other.gameObject);
		 	Destroy(gameObject);
		 	Destroy(explosion);
		 }
	}
}
