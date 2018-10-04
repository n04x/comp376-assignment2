using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathStar : MonoBehaviour {

	public GameObject explosion;
	private DeathStarHealth health_point;
	float DEATHSTAR_MOVEMENT = 7.0f;
	float timer;
	bool invincible = true;
	// Use this for initialization
	void Start () {
		GameObject health_point_object = GameObject.FindWithTag("DeathStarHealth");
		health_point = health_point_object.GetComponent<DeathStarHealth>();
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
		 if(other.tag == "Boundary") {
			 return;
		 }
		 if(invincible) {
			 Destroy(other.gameObject);
		 } else {
			health_point.DamageTaken(1);
			if(health_point.HPisZero()) {
				Instantiate(explosion, transform.position, Quaternion.identity);
				Destroy(other.gameObject);
				Destroy(gameObject);
				Destroy(explosion);
			}
		 }
	}
}
