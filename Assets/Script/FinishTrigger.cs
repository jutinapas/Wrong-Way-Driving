﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter2D()
	{
		gameManager.CompleteLevel ();
	}

}
