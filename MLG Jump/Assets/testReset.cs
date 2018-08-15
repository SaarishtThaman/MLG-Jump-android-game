using UnityEngine;
using UnityEngine.SceneManagement;

public class testReset : MonoBehaviour {
	public void reset() {
		SceneManager.LoadScene("SampleScene");
	}
}