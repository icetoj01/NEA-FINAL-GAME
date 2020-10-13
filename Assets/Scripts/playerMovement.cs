using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
	}

	// Once the player collides with a certain tag a specific process will be carried out
	//void OnCollisionEnter(Collision col)
	//{
	//if (col.gameObject.tag == "rightwall"){
	//	Debug.Log ("I collided with the " + col.gameObject.tag);
	//}
	//else if (col.gameObject.tag == "leftWall")
	//{
	//	Debug.Log ("I collided with the " + col.gameObject.tag);
	//}

	//else if (col.gameObject.tag == "floor") {
	//		Debug.Log ("I collided with the " + col.gameObject.tag);
	//}
	//}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (new Vector3 (6, 0, 0), ForceMode.Impulse); }

		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (new Vector3 (-6, 0, 0), ForceMode.Impulse); }

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector3 (0, 60, 0), ForceMode.Impulse);
			Debug.Log ("Jump Jump!"); }
	}



}
