using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempBarrier : MonoBehaviour {
	public GameObject tempWall;
	private float time = 26;



	// Use this for initialization
	void Start () {
		tempWall = GameObject.FindGameObjectWithTag ("temp_wall");
		Destroy (tempWall, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
