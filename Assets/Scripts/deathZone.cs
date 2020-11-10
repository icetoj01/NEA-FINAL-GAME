using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class deathZone : MonoBehaviour {



	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "death_zone")
		{
			Debug.Log("I collided with the " + col.gameObject.tag);
			//Destroy (gameObject);
			//re-loads the current scene
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Debug.Log ("Collided with death zone");
		}
	}
		
}