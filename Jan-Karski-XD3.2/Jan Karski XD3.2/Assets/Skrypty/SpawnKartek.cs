using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKartek : MonoBehaviour {
	public Transform kartka;
	public float PozycjaX, PozycjaY;

	// Use this for initialization
	void Start () {
		Instantiate (kartka, new Vector2 (PozycjaX, PozycjaY), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
