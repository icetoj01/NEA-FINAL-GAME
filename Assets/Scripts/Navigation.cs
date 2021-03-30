/*started: session 1
 *last edited: session 2
 *Aim of code: Allow the player to navigate through the start menu through the implementaion of buttons, this will allow for an easily understandable title menu.
*/

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

		SceneManager.LoadScene (3);
	}

	public void ClickedButtonBack1(){
		Debug.Log ("Back 1 clicked!");
		SceneManager.LoadScene (0);
	}
		

}
