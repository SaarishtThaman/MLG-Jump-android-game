using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundRepeat2 : MonoBehaviour {
	public backgroundRepeat1 bgr1;
	public GameObject background;
	public Vector3 pos;
	private Vector3 myPos;
	void Update() {
		pos = transform.position;
	}
	void OnTriggerEnter2D(Collider2D col) {
		if(col.CompareTag("destroyer")) {
			myPos = bgr1.pos;
			myPos.y += 6.51f; 
			background.transform.position = myPos;
		}
	}
}