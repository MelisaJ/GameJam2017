﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagController : MonoBehaviour {

	public float rightAngle = 0.0f;
	public float leftAngle = 180.0f;
	public float zigZagSpeed = 1.0f;
	bool leftRight = true;

	void Update(){
		if(transform.position.x >= 10) leftRight = false;
		if(transform.position.x <= -10) leftRight = true;

		if(leftRight){
			transform.position += Vector3.right * zigZagSpeed;
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, leftAngle, transform.eulerAngles.z);
		}
		if(!leftRight){
			transform.position += Vector3.right * -zigZagSpeed;	
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, rightAngle, transform.eulerAngles.z);
		} 
		

	}
}
