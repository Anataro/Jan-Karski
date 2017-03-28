using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Przegrałeś : MonoBehaviour {
	private GameManager gameManagerSkrypt;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Gracz") {
			SceneManager.LoadScene ("GameOver");
			gameManagerSkrypt.YouLose = true;
		} 
	}
}
