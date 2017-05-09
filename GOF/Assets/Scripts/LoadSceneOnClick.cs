using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Used for the main menu

public class LoadSceneOnClick : MonoBehaviour {

	// Use this for initialization
	public void LoadByIndex (int sceneIndex) {
        SceneManager.LoadScene (sceneIndex);
	}
}
