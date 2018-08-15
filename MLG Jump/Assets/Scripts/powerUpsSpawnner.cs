using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpsSpawnner : MonoBehaviour {

	public GameObject[] powerUps;
	private float edge = 2.2f;
	float spawnX;
	int rand;
	public float baseTimeBtwSpawn;
	float randomTime;

	void Start() {
		StartCoroutine(spawnPowerUp());
	}

	IEnumerator spawnPowerUp() {
		rand = Random.Range(0,powerUps.Length);
		randomTime = Random.Range(-5f,5f);
		spawnX = Random.Range(-edge,edge);
		yield return new WaitForSeconds(baseTimeBtwSpawn+randomTime);
		Vector3 spawnPos = transform.position;
		spawnPos.x = spawnX;
		Instantiate(powerUps[rand],spawnPos,Quaternion.identity);
		StartCoroutine(spawnPowerUp());
	}

}