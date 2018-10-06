using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {
	
	public float speed;
	private float HORIZONTAL_LIMIT = 6;
	private float VERTICAL_LIMIT = 4;
	Rigidbody2D ssRigidbody;
	Animator dmg_animation;
	SpriteRenderer sprite_renderer;
	public GameObject shot;
	public GameObject shot_level2;
	public GameObject shot_level3;
	GameObject space_ship_explosion_temp;
	public GameObject explosion;
	public Transform shotSpawn;
	public float fireRate;

	AudioSource ssLaserSound;
	private float nextFire;
	private int lives;
	private bool is_invincible;
	// Use this for initialization
	void Start () {
		lives = 1;
		is_invincible = false;
		ssRigidbody = GetComponent<Rigidbody2D>();
		ssLaserSound = this.GetComponent<AudioSource>();
		sprite_renderer = GetComponentInChildren<SpriteRenderer>();
		dmg_animation = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		// Check if our ship has lives left.
		if(lives == 0) {
			Destroy(gameObject);
			// StartCoroutine(KillOnAnimationEnd());
		}
		if(is_invincible) {
			InvincibleTrigger();
		}

		// instantiate our shooting of bolt.
		if(Input.GetKeyDown("space") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			if(lives == 1) {
				Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
				ssLaserSound.Play();
			} else if(lives == 2) {
				Instantiate(shot_level2, shotSpawn.position, shotSpawn.rotation);
				ssLaserSound.Play();
			} else {
				Instantiate(shot_level3, shotSpawn.position, shotSpawn.rotation);
				ssLaserSound.Play();
			}
		}
		// move our space ship around
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(horizontal, vertical);
		ssRigidbody.velocity = movement * speed;

		// check if the screen boundary is respected
		ssRigidbody.position = new Vector3(
			Mathf.Clamp(ssRigidbody.position.x, -HORIZONTAL_LIMIT, HORIZONTAL_LIMIT), 
			Mathf.Clamp(ssRigidbody.position.y, -VERTICAL_LIMIT, VERTICAL_LIMIT),
			0.0f	// Since the z axis will never change we set it to 0.
		);
	}
	public void DamageTaken() {
		lives--;
		if(lives != 0) {
			dmg_animation.Play("playerHit");
			is_invincible = true;
		}
	}
	public int GetHP() {
		return lives;
	}
	public void Upgrade() {
		lives++;
	}
	IEnumerator KillOnAnimationEnd() {
		this.sprite_renderer.enabled = false;
		space_ship_explosion_temp = Instantiate(explosion, transform.position, Quaternion.identity);			
		yield return new WaitForSeconds(0.5f);
		Destroy(gameObject);
		Destroy(space_ship_explosion_temp);
	}
	IEnumerator InvincibleTrigger() {
		yield return new WaitForSeconds(1.2f);
		is_invincible = false;
	}
}
