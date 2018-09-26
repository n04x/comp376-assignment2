using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour {

	private IEnumerator KillOnAnimationEnd() {
		yield return new WaitForSeconds(1.2f);
		Destroy(gameObject);
	}

	void Update()
	{
		StartCoroutine(KillOnAnimationEnd());		
	}
}