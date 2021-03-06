﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GUISkin displaySkin;

	private float 	_btnWidth = 75,
					_btnHeight = 30,
					_heightOffset = 40,
					_offsetWithTitle = 50,
					_rightOffset = 40;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnGUI(){

		GUI.skin = displaySkin;

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(Screen.width/2-_rightOffset,20+_offsetWithTitle,_btnWidth,_btnHeight), "Niveau 1")) {
			Application.LoadLevel("level1");
		}

		if(GUI.Button(new Rect(Screen.width/2-_rightOffset,60+_offsetWithTitle,_btnWidth,_btnHeight), "Niveau 2")) {
			Application.LoadLevel("level2");
		}

			// Make the forth button.
		if(GUI.Button(new Rect(Screen.width/2-_rightOffset,20+_offsetWithTitle+_heightOffset*3,_btnWidth,_btnHeight), "Quitter")) {
				Application.Quit();
			}

	}
}
