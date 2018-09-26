using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject enemyA;
	public Vector3 spawnPosition;
	float startWait = 1.0f;
	float spawnWait = 5.0f;
	
	void Start() {
		StartCoroutine(SpawnEnemyA());
		// SpawnEnemyA();
	}

	IEnumerator SpawnEnemyA() {
		yield return new WaitForSeconds(startWait);
		for(int i = 0; i < 3; i++) {
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(enemyA, spawnPosition, spawnRotation);
			yield return new WaitForSeconds(spawnWait);
		}
	}
}
