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
		if (Input.GetKey (KeyCode.Space)) {
			myAnimator.SetBool ("jump", true);
		} else {
			myAnimator.SetBool ("jump", false);
		}

		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			myAnimator.SetBool ("crouch", true);
		} else {
			myAnimator.SetBool ("crouch", false);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			myAnimator.SetBool ("standing jab", true);
		} else {
			myAnimator.SetBool ("standing jab", false);
		}
}
}