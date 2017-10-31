using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static int Xairplane;

	public static int Yairplane;

	public GameObject currentCube;

	public GameObject cubePre;

	public static GameObject redcube;

	public static bool cliked;

	GameObject[,]cubeRow;

	Vector3 cubePosition;




	// Use this for initialization


	/// This is to position the cubes, declare that "cliked is false", create a position to put a red cube at the top left of the game and, to make cubes no more than 16 x 9.
	void Start () {

		cliked = false;

		cubeRow = new GameObject[16,9];

		Xairplane = 0;

		Yairplane = 8;

		for (int y = 0; y < 9; y++){
			

			for (int x = 0; x < 16; x++) {

				////This is goint to make that the cubes stop after going 16 times in one x position and, it is going to stop after 9 times in one y position. 
		 		cubePosition = new Vector3 (x * 2, y * 2 - 8, 0);

				cubeRow [x, y] = (GameObject)Instantiate (cubePre, cubePosition, Quaternion.identity);

				cubeRow [x, y].GetComponent<Renderer> ().material.color = Color.white;

				cubeRow [x, y].GetComponent<Cube_Behavior> ().x = x;

				cubeRow [x, y].GetComponent<Cube_Behavior> ().y = y;

				//// The position of the red cube is alredy set, this is to create the red cube.
				if (Xairplane == x && Yairplane == y) {

					cubeRow [x, y].GetComponent<Renderer> ().material.color = Color.red;

					/// I assingned redcube as cubeRow.

					redcube = cubeRow [x, y];



				}				
		
													  }




			

										}

		
												}
				

					}


	
	
	

