using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float MoveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward*Time.deltaTime*MoveSpeed)

		if(Input.GetButton(KeyCode.UpArrow))
		{
			transform.
		}
	}
}
