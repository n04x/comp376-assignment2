using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject tie_fighter_object;
	// public GameObject star_destroyer_object;
	public Vector3 tie_fighter_spawn_pos;
	public Vector3 star_destroyer_spawn_pos;
	float startWait = 1.0f;
	float tie_fighter_spawnWait = 8.0f;
	float star_destroyer_startWait = 2.0f;
	float star_destroyer_spawnWait = 4.0f;
	
	void Start() {
		StartCoroutine(SpawnTIEFighter());
		// StartCoroutine(SpawnStarDestroyer());
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

	// IEnumerator SpawnStarDestroyer() {
	// 	yield return new WaitForSeconds(star_destroyer_startWait);
	// 	for(int i = 0; i < 5; i++) {
	// 		Quaternion spawnRotation = Quaternion.identity;
	// 		Instantiate(star_destroyer_object, star_destroyer_spawn_pos, spawnRotation);
	// 		yield return new WaitForSeconds(star_destroyer_spawnWait);
	// 	}
	// }
}
