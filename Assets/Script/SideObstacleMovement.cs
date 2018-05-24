﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideObstacleMovement : MonoBehaviour {

	public Rigidbody2D rb2d;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.AddForce (new Vector2 (speed, 0));
	}
}
