using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wygrałeś : MonoBehaviour {
	private GameManager gameManagerSkrypt;
	// Use this for initialization
	void Start () {
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager> ();
	}
	
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == ("Gracz") && gameManagerSkrypt.WszystkoZebrane == true) {
			gameManagerSkrypt.YouWon = true;
			SceneManager.LoadScene ("YouWon");
		}
	}
}
