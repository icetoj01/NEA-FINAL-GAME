using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {
	public void  ClickedButtonA(){
		Debug.Log ("Start!");
	}

	public void  ClickedButtonB(){
		Debug.Log ("Difficulty!");
	}

	public void  ClickedButtonC(){
		Debug.Log ("Exit!");
	}

	public void  ClickedButtonD(){
		Debug.Log ("Tutorial!");

		SceneManager.LoadScene (1);
	}

	public void  ClickedButtonE(){
		Debug.Log ("Movement");
		SceneManager.LoadScene (3);
	}

	public void  ClickedButtonF(){
		Debug.Log ("Attacking!");
	}

}
