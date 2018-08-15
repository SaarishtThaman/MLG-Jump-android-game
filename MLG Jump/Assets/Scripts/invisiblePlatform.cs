using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisiblePlatform : MonoBehaviour {
	public float visibleTime, invisibleTime;
	private int state = 1; // 1 = invisible, 0 = visible
	Animator animator;

	void Start() {
		animator = GetComponent<Animator>();
		StartCoroutine(active());
	}

	IEnumerator active() {
		animator.Play("fadeIn");
		state = 1;
		yield return new WaitForSeconds(visibleTime);
		StartCoroutine(unActive());
	}
	IEnumerator unActive() {
		animator.Play("fadeOut");
		state = 0;
		yield return new WaitForSeconds(invisibleTime);
		StartCoroutine(active());
	}

	void Update() {
		if(state == 1) {
			gameObject.tag = "Platform";
		}
		else if(state == 0) {
			gameObject.tag = "sike";
		}
	}
}