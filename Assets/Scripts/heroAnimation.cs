using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroAnimation : MonoBehaviour {
	Animator myAnimator;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			myAnimator.SetBool ("walk", true);
		}
		else {
			myAnimator.SetBool ("walk", false);
	}
}
}