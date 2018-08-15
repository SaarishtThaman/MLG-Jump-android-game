using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject player;
	PlayerController control;

	void Start() {
		control = player.GetComponent<PlayerController>();
	}
	void Update() {
		if(control.ySpeed > 0 && transform.position.y < control.yCoor) {
			transform.Translate(0,control.ySpeed * Time.deltaTime,0);
		}
	}
}