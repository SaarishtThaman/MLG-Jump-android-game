using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundRepeat1 : MonoBehaviour {
	public backgroundRepeat2 bgr2;
	public GameObject background;
	private Vector3 myPos;
	public Vector3 pos;

	void Update() {
		pos = transform.position;
	}
	void OnTriggerEnter2D(Collider2D col) {
		if(col.CompareTag("destroyer")) {
			myPos = bgr2.pos;
			myPos.y += 6.51f; 
			background.transform.position = myPos;
		}
	}
}