﻿using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour 
{
	public float speed = 30;

	void FixedUpdate () 
	{
		float v = Input.GetAxisRaw ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * speed;
		//test
	}
}
