﻿using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	private static bool paused = false;
	private static int lives = 3;
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.LoadLevel("Menu");
		}

		if (Input.GetButtonDown("Pause")) {
			if (paused) {
				Time.timeScale = 0f;
			} else {
				Time.timeScale = 1f;
			}
			paused = !paused;
		}

	}

	public static bool Paused(){
		return paused;
	}

	public static void LifeLost() {

		--lives;
		if (lives == 0) {
			Application.LoadLevel("GameOver");
		} else {
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}