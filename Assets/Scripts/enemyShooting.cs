using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour {
	public float time_between_attack;
	public GameObject shot;
	public Transform shotSpawn;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnShot());
	}
	
	IEnumerator SpawnShot() {
		while(true) {
			yield return new WaitForSeconds(time_between_attack);
			Instantiate(shot, transform.position, Quaternion.identity);			
		}
	}
}