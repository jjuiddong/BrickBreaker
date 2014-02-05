using UnityEngine;
using System.Collections;

public class Plank : MonoBehaviour {

	public KeyCode leftMoveKeyCode;
	public KeyCode rightMoveKeyCode;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(leftMoveKeyCode))
		{
			Vector3 pos;
			pos.x = -0.1f;
			pos.y = 0;
			pos.z = 0;
			transform.Translate( pos );
		}

		if (Input.GetKey(rightMoveKeyCode))
		{
			Vector3 pos;
			pos.x = 0.1f;
			pos.y = 0;
			pos.z = 0;
			transform.Translate( pos );
		}

	}
}
