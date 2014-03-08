﻿using UnityEngine;
using System.Collections;

public class FallingBox : MonoBehaviour 
{
	bool shaking;
	bool falling;
	float pos;
	float increment;
	int cpt;

	// Use this for initialization
	void Start () 
	{
		increment = 0.1f;
		shaking = false;
		falling = false;
		cpt = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(shaking)
		{
			Vector2 temp = transform.position;
			temp.x = transform.position.x + increment;
			transform.position = temp;
			pos += increment;
			if(pos >= 0.3f || pos <= -0.3f)
			{
				increment *= -1;
				cpt++;
			}
			if(cpt == 4 && pos < 0.1f && pos > -0.1f)
			{
				shaking = false;
				falling = true;
			}
		}
		if(falling)
		{
			Vector2 temp = transform.position;
			temp.y = transform.position.y + -0.1f;
			transform.position = temp;
		}
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		if(collider.gameObject == GameObject.Find ("Player"))
		{
			if(collider.transform.position.y - 0.98 <= transform.position.y)
				shaking = true;
		}
	}
}
