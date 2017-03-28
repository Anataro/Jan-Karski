using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadRootKartki3 : MonoBehaviour {
	public static bool obiektIstnieje;

	// Use this for initialization
	void Start () {
		if (!obiektIstnieje) {
			obiektIstnieje = true;
			DontDestroyOnLoad (transform.root.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
