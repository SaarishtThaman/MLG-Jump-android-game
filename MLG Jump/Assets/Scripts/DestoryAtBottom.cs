using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAtBottom : MonoBehaviour {
	public AudioClip[] fall;
	AudioSource aSource;
	public bool GameOver = false;
	AudioSource audioSource;
	public GameObject MusicManager;
	int rand;

	void Start() {
		aSource = GetComponent<AudioSource>();
	}
	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.CompareTag("Platform") || coll.CompareTag("superPlatform") || coll.CompareTag("hitMarker") || coll.CompareTag("sike") || coll.CompareTag("PowerUp")) {
			Destroy(coll.gameObject,2);
		}
		if(coll.CompareTag("Player")) {
			rand = Random.Range(0,fall.Length);
			aSource.PlayOneShot(fall[rand]);
			Destroy(coll.gameObject);
			GameOver = true;
			audioSource = MusicManager.GetComponent<AudioSource>();
			audioSource.Stop();
		}
	}
}