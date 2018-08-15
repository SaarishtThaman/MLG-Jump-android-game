using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingBG : MonoBehaviour {

		SpriteRenderer sr;

		void Start() {
			sr = GetComponent<SpriteRenderer>();
			StartCoroutine(Lights());
		}

		IEnumerator Lights() {
			sr.color = Color.white;

			yield return new WaitForSeconds(0.08f);

			sr.color = Color.red;

			yield return new WaitForSeconds(0.08f);

			sr.color = Color.blue;

			yield return new WaitForSeconds(0.08f);
			StartCoroutine(Lights());

		}

}