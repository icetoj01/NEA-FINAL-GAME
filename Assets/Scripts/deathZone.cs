using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathZone : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "death_zone") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			Debug.Log ("Collided with death zone");
		}
	}






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
