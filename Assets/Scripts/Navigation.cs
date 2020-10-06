﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {


// These lines of code detect when a button is clicked and depending on the button takes the user to a separate screen
	public void  ClickedButtonA(){
		Debug.Log ("Start clicked!");
	}

	public void  ClickedButtonB(){
		Debug.Log ("Difficulty clicked!");
	}

	public void  ClickedButtonC(){
		Debug.Log ("Quit clicked!");


	}
	public void  ClickedButtonD(){
		Debug.Log ("Tutorial clicked!");

	//SceneManager loads a chosen scene different from the one that is currently option e.g. an options menu
		SceneManager.LoadScene(1);
	}

	public void  ClickedButtonE(){
		Debug.Log ("Movement clicked!");

		SceneManager.LoadScene(3);
	}

	public void  ClickedButtonF(){
		Debug.Log ("Attacking clicked!");
	}

	public void  ClickedButtonG(){
		Debug.Log ("Back_Tutorial Clicked clicked!");
		Debug.Log ("Main menu loaded!");

		SceneManager.LoadScene(0);
	}
}
