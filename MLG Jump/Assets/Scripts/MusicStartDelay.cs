using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStartDelay : MonoBehaviour {

	public AudioClip music;
	AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource>();
		audioSource.loop = true;
		audioSource.clip = music;
		audioSource.PlayDelayed(0.5f);
		audioSource.Play();
	}

}