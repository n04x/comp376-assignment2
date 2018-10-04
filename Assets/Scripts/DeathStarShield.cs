using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathStarShield : MonoBehaviour {
	// public gameObject shield;
	float SHIELD_MOVEMENT = 7.0f;
	bool invincible = true;
	bool is_destroyed = false;
	float movement_timer;
	float respawn_timer = 5.0f;
	float death_timer = 0.0f;
	SpriteRenderer sprite_renderer;
	Collider2D collider_2d;
	// Use this for initialization
	void Start () {
		sprite_renderer = GetComponent<SpriteRenderer>();
		collider_2d = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement_timer += Time.deltaTime;
		if(movement_timer < SHIELD_MOVEMENT) {
			transform.Translate(-Vector2.up * Time.deltaTime);			
		} else {
			invincible = false;
		}
		// Check if the shield is down
		if(is_destroyed) {
			death_timer += Time.deltaTime;
		}
		// Check if the shield has been down for a while.
		if(is_destroyed && death_timer >= respawn_timer) {
			this.sprite_renderer.enabled = true;
			this.collider_2d.enabled = true;
			is_destroyed = false;
			death_timer = 0.0f;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Boundary" || other.tag == "EnemyBolt") {
			return;
		}
		if(invincible) {
			Destroy(other.gameObject);
		} else {
			Destroy(other.gameObject);
			this.sprite_renderer.enabled = false;
			this.collider_2d.enabled = false;
			is_destroyed = true;
		}
	}
}
