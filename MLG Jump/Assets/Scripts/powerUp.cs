using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {

	float RandomSpeed;
	public ScoreManager sm;
	public int scoreIncreaseVal;
	public AudioClip collectSound;
	AudioSource audioSource;

	void Start() {
		RandomSpeed = Random.Range(1.5f,4);
		audioSource = GetComponent<AudioSource>();
	}

	void Update() {
		transform.Translate(0,-RandomSpeed*Time.deltaTime,0);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if(col.CompareTag("Player")) {
			sm = col.gameObject.GetComponent<ScoreManager>();
			audioSource.PlayOneShot(collectSound);
			sm.score += scoreIncreaseVal;
			transform.position = new Vector3(5,transform.position.y,transform.position.z);
		}
	}

}