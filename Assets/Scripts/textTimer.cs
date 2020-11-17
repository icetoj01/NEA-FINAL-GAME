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

