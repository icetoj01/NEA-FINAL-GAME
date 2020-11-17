/* started: session 3 
 *last edited: session 4
 *Aim of code: To enable the movement os the player in 4 directions, left, right, up and down (crouch
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


public bool useGravity = true;
	// Code used as reference: https://answers.unity.com/questions/1543639/how-to-set-individual-rigidbody-gravity-solved.html?_ga=2.219687641.1588503329.1603180981-1714542316.1600768558

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		//freezeRotation prevents the player from being able to roll or change its rotation in any way
		rb.freezeRotation = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (new Vector3 (6, 0, 0), ForceMode.Impulse);

		}

		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (new Vector3 (-6, 0, 0), ForceMode.Impulse);

		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector3 (0, 200, 0), ForceMode.Impulse);
			Debug.Log ("Jump Jump!");
			useGravity = true;

		}
	}

	// Code used as reference: https://answers.unity.com/questions/1543639/how-to-set-individual-rigidbody-gravity-solved.html?_ga=2.219687641.1588503329.1603180981-1714542316.1600768558
	 void FixedUpdate () {

		rb.useGravity = false;
		if (useGravity)
			rb.AddForce (Physics.gravity * (6 * 6));
	}



}
