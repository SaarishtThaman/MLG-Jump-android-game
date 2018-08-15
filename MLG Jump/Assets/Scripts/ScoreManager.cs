using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text Score;
	public int score = 0;
	int max;

	void start() {
		score = 0;
		max = 0;
	}

	void Update() {
		max = (int)transform.position.y/20;
		if(transform.position.y > 0 && max > score) {
			score = max; 
		}
		Score.text = ""+score;
	}

}