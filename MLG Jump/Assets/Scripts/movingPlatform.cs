using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour {

	private int dir = 0; //right = 0 , left = 1
	float moveSpeed;
	float edge = 2.2f;
	public float minSpeed, maxSpeed;

	void Start() {
		moveSpeed = Random.Range(minSpeed,maxSpeed);
	}

	void Update() {
		if(dir == 0) {
			transform.Translate(moveSpeed*Time.deltaTime,0,0);
		}
		else if(dir == 1) {
			transform.Translate(-moveSpeed*Time.deltaTime,0,0);
		}


		if(transform.position.x >= edge && dir == 0) {
			dir = 1;
		}
		else if(transform.position.x <= -edge && dir == 1) {
			dir = 0;
		}
	}
}