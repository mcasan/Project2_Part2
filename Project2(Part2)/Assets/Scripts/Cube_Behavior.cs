using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Behavior : MonoBehaviour {
	
public GameObject cubePrep;
	 
public	int x;

public	int y;

/// When the mouse is cliked and "it is not" a red cube then it can turn to a white cube. 

	void OnMouseDown () {


		if (GameController.redcube != null) {

			GameController.redcube.GetComponent<Renderer> ().material.color = Color.white;
		
		}

		//// When a cube is cliked, then, it becomes a red cube. 
 
		gameObject.GetComponent<Renderer> ().material.color = Color.red;

		GameController.redcube = gameObject;

////  When the red cube of the top left of the game it is not a red cube anymore, then, it becomes a blue cube. 

		if (gameObject == GameController.redcube && GameController.cliked == false) {	

			gameObject.GetComponent<Renderer> ().material.color = Color.blue;

			GameController.cliked = true;
	


		}


	}
}


