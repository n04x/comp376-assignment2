﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject tie_fighter_object;
	public GameObject star_destroyer_object;
	public GameObject death_star_object;
	public Vector3 tie_fighter_spawn_pos;
	public Vector3 star_destroyer_spawn_pos;

	public Vector3 death_star_spawn_pos;
	float startWait = 1.0f;
	float tie_fighter_spawnWait = 8.0f;
	float star_destroyer_startWait = 20.0f;
	float death_star_startWait = 40.0f   ;
	// float star_destroyer_spawnWait = 4.0f;
	
	void Start() {
		StartCoroutine(SpawnTIEFighter());
		StartCoroutine(SpawnStarDestroyer());
		StartCoroutine(SpawnDeathStar());
		// SpawnEnemyA();
	}

	IEnumerator SpawnTIEFighter() {
		yield return new WaitForSeconds(startWait);
		for(int i = 0; i < 2; i++) {
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(tie_fighter_object, tie_fighter_spawn_pos, spawnRotation);
			yield return new WaitForSeconds(tie_fighter_spawnWait);
		}
	}

	IEnumerator SpawnStarDestroyer() {
		yield return new WaitForSeconds(star_destroyer_startWait);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate(star_destroyer_object, star_destroyer_spawn_pos, spawnRotation);
	}

	IEnumerator SpawnDeathStar() {
		yield return new WaitForSeconds(death_star_startWait);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate(death_star_object, death_star_spawn_pos, spawnRotation);
	}
}
