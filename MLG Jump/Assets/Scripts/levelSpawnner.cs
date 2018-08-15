using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSpawnner : MonoBehaviour {
	public GameObject[] levels;
	Vector3 instantiatePos;
	public float aboveVal;
	public float belowVal;
	levelSpawnner ls;
	int rand;

	void Start() {
		rand = Random.Range(0,levels.Length);
		ls = levels[rand].GetComponent<levelSpawnner>();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if(col.CompareTag("destroyer")) {
			instantiatePos = transform.position;
			instantiatePos.y += aboveVal+ls.belowVal;
			Instantiate(levels[rand],instantiatePos,Quaternion.identity);
		}
	}

}