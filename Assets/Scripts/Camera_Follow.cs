/* started: session 4 
 *last edited: session 6
 *Aim of code: To have the camera placed in a fixed postion, only being able to move horizontally no matter if the user changes elevation
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("user");
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x + 3, 1, -10);
	}
}
