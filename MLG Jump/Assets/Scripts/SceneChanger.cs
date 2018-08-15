using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	Animator animator;
	public AudioSource music;

	void Start () {
		animator = GetComponent<Animator>();
	}
	

	public void FadeToGame() {
		animator.Play("ScenetoDark");
		StartCoroutine(waitOneSecond());
	}

	IEnumerator waitOneSecond() {
		music.volume = 0.2f;
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene("SampleScene");
	}
}
