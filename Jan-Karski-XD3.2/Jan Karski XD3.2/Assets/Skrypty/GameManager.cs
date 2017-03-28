using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GUIText LicznikKartek, MusiszZebracWszystkieKartki;
	public int zebranekartki;
	private PrzechodzeniePrzezSceny skrypt;

	public bool YouWon, YouLose, WszystkoZebrane;

	private static bool obiektIstnieje;

	void Start (){
		if (!obiektIstnieje) {
			obiektIstnieje = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
	}

}

	void Update(){
		if (zebranekartki == 10) {
			WszystkoZebrane = true;
		} else {
			WszystkoZebrane = false;
		}

		/*if (Input.GetKey (KeyCode.Y) && YouWon == true){
			kartki = GameObject.FindGameObjectsWithTag ("Kartka");
				foreach (GameObject kartka in kartki){
					Destroy (gameObject);}
			
			SceneManager.LoadScene ("Gra");
			zebranekartki = 0;
	}*/ //NIE DZIAŁA
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
			

		LicznikKartek.text = zebranekartki.ToString () + "/10";

	}


}