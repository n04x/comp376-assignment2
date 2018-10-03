using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	
	public GameObject explosion;
	public int score_value;
	public int ship_number;
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
		if(other.tag == "Player") {
			space_ship.DamageTaken();
			return;
		}
		game_controller.ShipDestroyed();
		Instantiate(explosion, transform.position, Quaternion.identity);
		game_controller.AddScore(score_value);
		Destroy(other.gameObject);
		Destroy(gameObject);
		Destroy(explosion);
	}
}
