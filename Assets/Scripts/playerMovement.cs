/* started: session 3 
 *last edited: session 4
 *Aim of code: To enable the movement os the player in 4 directions, left, right, up and down (crouch
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	private float speed;
	private float boostTimer;
	private bool boosting;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		//freezeRotation prevents the player from being able to roll or change its rotation in any way
		rb.freezeRotation = true;

		speed = 1;
		boostTimer = 0;
		boosting = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (new Vector3 (speed, 0, 0), ForceMode.Impulse);

		}

		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (new Vector3 (-speed, 0, 0), ForceMode.Impulse);

		}

		if (boosting) {
			boostTimer += Time.deltaTime;
			if (boostTimer >= 10)
			{
				speed = 1;
				boostTimer = 0;
				boosting = false;
			}
		}
			

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector3 (0, 20, 0), ForceMode.Impulse);
			Debug.Log ("Jump Jump!");


		}
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "speedBuff") {
			boosting = true;
			speed = 2;
			Destroy (other.gameObject);
		}
	}








	}




