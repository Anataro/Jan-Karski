using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

	private PlayerController thePlayer;
	private Save saveSkrypt;

	public string pointName;

	void Start () {
		thePlayer = FindObjectOfType<PlayerController>();

		if (thePlayer.startPoint == pointName) {
			thePlayer.transform.position = transform.position;
		}

		GameObject objekt2 = GameObject.Find ("Gracz");
		saveSkrypt = objekt2.GetComponent<Save> ();
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Gracz") {
			saveSkrypt.SavePosition ();
		}
	}
			

	// Update is called once per frame
	/*void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			thePlayer.transform.position = transform.position;
		}
	}*/
}
