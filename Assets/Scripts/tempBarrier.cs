/* started: session 6 
 *last edited: session 6
 *Aim of code: Prevent the user from moving on with the tutorial until each instruction has been given
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempBarrier : MonoBehaviour {
	public GameObject tempWall;
	private float time = 6;



	// Use this for initialization
	void Start () {
		tempWall = GameObject.FindGameObjectWithTag ("temp_wall");
		Destroy (tempWall, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
