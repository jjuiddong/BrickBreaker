﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Vector3 m_Velocity;


	// Use this for initialization
	void Start () 
	{
		m_Velocity = new Vector3 (0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 pos = m_Velocity * Time.deltaTime;
		transform.Translate( pos );
	}

	void Shoot( Vector3 velocity )
	{
		m_Velocity = velocity;
	}

	void OnCollisionEnter(Collision other)
	{
		print ("collision ball enter");

		float power = 5;
		Vector3 vel = (other.transform.position - transform.position).normalized;
		vel.y = 0;
		vel = -vel.normalized * power;
		//GameObject.Find("Ball").SendMessage ("Shoot", vel);

		print (vel);
		Shoot (vel);
	}

	void OnTriggerEnter(Collider other)
	{
		print ("trigger enter");
	}
}
