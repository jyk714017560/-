using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float MoveSpeed;
	public GameObject Food;

	// Use this for initialization
	void Start () {
		Creat_Food ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.forward * Time.deltaTime * MoveSpeed);

		if(Input.GetKeyDown(KeyCode.UpArrow)&&Vector3.Angle(Vector3.forward,this.transform.forward)<=110f)
		{
			transform.forward = Vector3.forward;
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)&&Vector3.Angle(Vector3.back,this.transform.forward)<=110f)
		{
			this.transform.forward = Vector3.back;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)&&Vector3.Angle(Vector3.left,this.transform.forward)<=110f)
		{
			this.transform.forward = Vector3.left;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)&&Vector3.Angle(Vector3.right,this.transform.forward)<=110f)
		{
			this.transform.forward = Vector3.right;
		}
			
	}

	void Creat_Food()
	{
		float Food_x=Random.Range(-4f,4f);
		float Food_z=Random.Range(-4f,4f);
		Food = Instantiate (Food, new Vector3 (Food_x, 0, Food_z),Quaternion.identity)as GameObject;
	}


	void OnTriggerEnter(Collider other)
	{  
		if (other.tag=="food") 
		{  			
			Destroy (other.gameObject);  
			Creat_Food ();
		}  
	}
}
