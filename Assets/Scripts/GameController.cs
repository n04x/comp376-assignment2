using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject enemyA;
	public Vector3 spawnPosition;
	public int wavesA;
	
	void Start() {
		SpawnEnemyA();
	}

	void SpawnEnemyA() {

		for(;;) {
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(enemyA, spawnPosition, spawnRotation);
		} 
	}
}
