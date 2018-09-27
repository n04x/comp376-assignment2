﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
	public Renderer rend;
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * speed;

		rend.material.mainTextureOffset = new Vector2(0, offset);	
	}
}
