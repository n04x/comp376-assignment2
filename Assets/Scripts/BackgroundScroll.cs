using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
	public Renderer rend;
	public float speed = 0.5f;
	float timer;
	float BACKGROUND_SCROLLING_TIME = 45.0f;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer < BACKGROUND_SCROLLING_TIME) {
			float offset;
			if(timer > (BACKGROUND_SCROLLING_TIME - 5.0f)) {
				offset = Time.time * (speed / 2.0f);
			} else {
				offset = Time.time * speed;
			}
			rend.material.mainTextureOffset = new Vector2(0, offset);	
		}
	}
}
