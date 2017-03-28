using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour {
	private GameObject objekt;
	private GameManager gameManagerSkrypt;

	void Start (){
		objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager> ();
	}

	public void SavePosition() {
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;

		PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
		PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
		PlayerPrefs.SetFloat ("PlayerZ", transform.position.z);

		PlayerPrefs.SetString ("NumerSceny", currentScene.name);

		//PlayerPrefs.SetInt ("IloscKartek", gameManagerSkrypt.zebranekartki);
	}

	public void LoadPosition (){
	
		float x = PlayerPrefs.GetFloat ("PlayerX");
		float y = PlayerPrefs.GetFloat ("PlayerY");
		float z = PlayerPrefs.GetFloat ("PlayerZ");

		SceneManager.LoadScene (PlayerPrefs.GetString ("NumerSceny"));

		//gameManagerSkrypt.zebranekartki = PlayerPrefs.GetInt ("IloscKartek");

		transform.position = new Vector3 (x, y, z);
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.R) /*&& (gameManagerSkrypt.YouLose == true)*/) {
			gameManagerSkrypt.YouLose = false;
			LoadPosition ();
		}
	}
}
