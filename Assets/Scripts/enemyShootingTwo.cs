using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShootingTwo : MonoBehaviour {
	public float time_between_attack;
	public GameObject shot;
	public Transform shotSpawn;
	public Transform shotSpawnTwo;
	AudioSource laser_sound;
	// Use this for initialization
	void Start () {
		laser_sound = GetComponent<AudioSource>();
		StartCoroutine(SpawnShot());
	}
	
	IEnumerator SpawnShot() {
		while(true) {
			yield return new WaitForSeconds(time_between_attack);
			Instantiate(shot, shotSpawn.position, Quaternion.identity);
			Instantiate(shot, shotSpawnTwo.position, Quaternion.identity);
			laser_sound.Play();	
		}
	}
}