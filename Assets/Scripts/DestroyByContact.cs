﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	
	public GameObject explosion;
	public GameObject playerExplosion;
	GameObject explosion_temp;
	GameObject space_ship_explosion_temp;
	public int score_value;
	private GameController game_controller;
	private SpaceShip space_ship;
	
	void Start() {
		GameObject game_controller_object = GameObject.FindWithTag("GameController");
		GameObject space_ship_object = GameObject.FindWithTag("Player");
		space_ship = space_ship_object.GetComponent<SpaceShip>();
		if(game_controller_object != null) {
			game_controller = game_controller_object.GetComponent<GameController>();
		}	
		if(game_controller == null) {
			Debug.Log("cant find 'GameController' script");
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{	
		if(other.tag == "Boundary") {
			return;
		}
		if(other.tag == "EnemyBolt") {
			return;
		}
		if(other.tag == "Player") {
			space_ship.DamageTaken();
			if(space_ship.GetHP() == 0) {
				Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
				game_controller.GameOver();
			}
			return;
		}
		game_controller.ShipDestroyed();
		explosion_temp = Instantiate(explosion, transform.position, Quaternion.identity);
		game_controller.AddScore(score_value);
		Destroy(other.gameObject);
		Destroy(gameObject);
		Destroy(explosion_temp);
	}
}
