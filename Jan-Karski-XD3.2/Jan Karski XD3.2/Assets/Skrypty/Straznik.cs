using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straznik : MonoBehaviour {

	public Waypoint[] path;
	public float reachDist = 0.1f;
	public int currentWaypoint; 
	public bool pause;
	public float speed; 


	Transform player; 


	void Start()
	{
	}

	void Update()
	{
		if (currentWaypoint == 4) {
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0.0f);
		}
		if (currentWaypoint == 0) {
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 180.0f);

		}
		if (currentWaypoint == 1) {
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0.0f);
		}

		
		Patrol ();

	}


	void Patrol ()
	{
		float distance = Vector3.Distance (path [currentWaypoint].transform.position, transform.position);

		if (!pause) {
			transform.position = Vector3.MoveTowards (transform.position, path [currentWaypoint].transform.position, speed * Time.deltaTime);

			if (currentWaypoint == 2) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 270.0f);
			}
			if (currentWaypoint == 3) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 90.0f);
			}
			if (currentWaypoint == 5) {
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0.0f);
			}

			if (distance < reachDist) {
				
				StartCoroutine (GuardPause ());
				currentWaypoint++;



			
				if (currentWaypoint >= path.Length) {


					currentWaypoint = 0;
				}
			}	
		}
}

	void DetectPlayer()
	{
		
	}





	IEnumerator GuardPause()
	{
		pause = true;
		yield return new WaitForSeconds (path [currentWaypoint].pauseTime);
		pause = false;
	}
}
