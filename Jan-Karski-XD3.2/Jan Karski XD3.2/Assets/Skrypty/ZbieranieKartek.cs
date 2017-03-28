using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZbieranieKartek : MonoBehaviour {
	private GameManager GameManagerSkrypt;
	private Save skryptSave;

	void Start (){
		GameObject kartka = GameObject.Find ("GameManager");
		GameManagerSkrypt = kartka.GetComponent<GameManager> ();

		/*GameObject objekt = GameObject.Find ("Gracz");
		skryptSave = objekt.GetComponent<Save> ();*/
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Gracz") {
			GameManagerSkrypt.zebranekartki += 1;
			//skryptSave.SavePosition ();
			transform.position = new Vector2 (transform.position.x, 9999.0f);
		}
	}
}
