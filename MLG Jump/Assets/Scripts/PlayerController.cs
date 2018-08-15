using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	Rigidbody2D rb;
	AudioSource audioSource;
	public GameObject hitMarker;
	public AudioClip boing;
	private float flipSensitivity = 0.0001f;
	public AudioClip[] sike;
	int randSike;
	public AudioClip superPlatformJump;
	public float tiltSensitivity, upForce;
	[HideInInspector]public float yCoor, ySpeed;
	private float edge = 2.85f;
	private Vector2 speed;
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource>();
	}

	void Update() {

		yCoor = transform.position.y;
		ySpeed = rb.velocity.y;

		if(Input.acceleration.x > flipSensitivity) {
			transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
		}
		else if(Input.acceleration.x < -flipSensitivity) {
			transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
		}


		transform.Translate(tiltSensitivity* Input.acceleration.x,0,0);
		if(Input.acceleration.x < 0 && transform.position.x <= -edge) {
			Vector3 newPos = transform.position;
			newPos.x = edge;
			transform.position = newPos;
		}
		else if(Input.acceleration.x > 0 && transform.position.x >= edge) {
			Vector3 newPos = transform.position;
			newPos.x = -edge;
			transform.position = newPos;
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.CompareTag("Platform") && rb.velocity.y < 0) {
			audioSource.PlayOneShot(boing);
			rb.velocity = new Vector2(rb.velocity.x, upForce);
		}
		else if(coll.CompareTag("superPlatform") && rb.velocity.y < 0) {
			Vector3 hitMarkerPos = transform.position;
			hitMarkerPos.y -= 0.32f;
			Instantiate(hitMarker,hitMarkerPos,Quaternion.identity);
			audioSource.PlayOneShot(superPlatformJump);
			rb.velocity = new Vector2(rb.velocity.x, upForce*1.4f);
		}
		else if(coll.CompareTag("sike") && rb.velocity.y < 0) {
			randSike = Random.Range(0,sike.Length);
			audioSource.PlayOneShot(sike[randSike]);
		}
	}
}