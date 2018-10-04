using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

	Animator dmg_animation;

	void Start() {
		dmg_animation = GetComponent<Animator>();	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "EnemyBolt") {
			dmg_animation.Play("playerHit");
		}	
	}
}
