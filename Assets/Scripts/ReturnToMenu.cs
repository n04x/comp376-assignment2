﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Cancel")) {
			SceneManager.LoadScene(0);
		}		
	}
}
