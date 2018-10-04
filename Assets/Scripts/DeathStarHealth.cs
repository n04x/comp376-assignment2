using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathStarHealth : MonoBehaviour {

	public Text hp_text;
	private int hp_value;
	// Use this for initialization
	void Start () {
		hp_value = 15;
		StartCoroutine(HP());
	}
	
	IEnumerator HP() {
		yield return new WaitForSeconds(40);
		UpdateHealth();
	}
	public void DamageTaken (int dmg) {
		hp_value -= dmg;
		UpdateHealth();
	// Update is called once per frame
	}

	void UpdateHealth() {
		hp_text.text = "Boss Health Point: " + hp_value;
	}

	public bool HPisZero() {
		if(hp_value == 0) {
			return true;
		} else {
			return false;
		}
	}
}
