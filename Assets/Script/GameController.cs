using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Invoke ("ShootTimer", 1);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void ShootTimer()
	{
		GameObject.Find("Ball").SendMessage ("Shoot", new Vector3(0,0,1));
	}

}
