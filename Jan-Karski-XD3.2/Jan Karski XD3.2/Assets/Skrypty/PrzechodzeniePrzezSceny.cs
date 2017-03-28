using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrzechodzeniePrzezSceny : MonoBehaviour {
	public string JakąScenęZaładować;

	public string exitPoint;
	private PlayerController thePlayer;

	public int IleKartekTrzebaZebrac;
	public bool MozeszPrzejsc;
	private GameManager gameManagerSkrypt;
	private Save saveSkrypt;

	void Start(){
		thePlayer = FindObjectOfType<PlayerController> ();

		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager> ();

	}

	void Update (){
		if (gameManagerSkrypt.zebranekartki == IleKartekTrzebaZebrac || gameManagerSkrypt.zebranekartki > IleKartekTrzebaZebrac) {
			MozeszPrzejsc = true;
		} else {
			MozeszPrzejsc = false;
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Gracz" && MozeszPrzejsc == true) {
			SceneManager.LoadScene (JakąScenęZaładować);
			thePlayer.startPoint = exitPoint;
		} else {
			StartCoroutine (CzyMoznaPrzejsc ());
		}
	} 

	IEnumerator CzyMoznaPrzejsc(){
			gameManagerSkrypt.MusiszZebracWszystkieKartki.text = "Musisz najpierw zebrać wszystkie kartki!";
			yield return new WaitForSeconds(2);
			gameManagerSkrypt.MusiszZebracWszystkieKartki.text = "";
		}
	}

	



