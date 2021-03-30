using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour {

	public int Score = 0;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "coin")
		{

			scoreValue += 5;
			Destroy (other.gameObject);
	}
}


	public static int scoreValue = 0;
	Text score;


	void Start () {
		score = GetComponent<Text> ();
	}


	void Update () {
		score.text = "SCORE: " + scoreValue;
	}
















}
