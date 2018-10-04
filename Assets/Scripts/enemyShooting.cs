using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour {
	public float time_between_attack;
	public GameObject shot;
	public Transform shotSpawn;
	AudioSource laser_sound;
	// Use this for initialization
	void Start () {
		laser_sound = GetComponent<AudioSource>();
		StartCoroutine(SpawnShot());
	}
	
	IEnumerator SpawnShot() {
		while(true) {
			yield return new WaitForSeconds(time_between_attack);
			Instantiate(shot, transform.position, Quaternion.identity);
			laser_sound.Play();	
		}
	}
}