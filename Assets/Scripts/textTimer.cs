/* started: session 6
 *last edited: session 6
 *Aim of code: To display further instructions and remove old ones after a certain amount of time has passed to allow for the user to continue to learn the mechanics of the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textTimer : MonoBehaviour {
	public float time = 6;
	public GameObject spacetext;



	// Use this for initialization
	void Start () {
		spacetext = GameObject.FindGameObjectWithTag ("tutorial_text");
		Destroy (spacetext, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

