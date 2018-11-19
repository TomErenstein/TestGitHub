using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigateToScene : MonoBehaviour {

	[SerializeField]

	string SceneToLoad;

	public void LoadNextScene() {
		SceneManager.LoadScene(SceneToLoad);
	}
}
