using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {
	public GameObject target;
	public static bool obiektIstnieje;

	void Start(){
		transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10.0f);

		if (!obiektIstnieje) {
			obiektIstnieje = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
		
	void FixedUpdate () {
		transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10.0f);
	}
}