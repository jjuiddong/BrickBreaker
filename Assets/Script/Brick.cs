﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter( Collision other )
	{
		print ("collision brick");
	}


}
