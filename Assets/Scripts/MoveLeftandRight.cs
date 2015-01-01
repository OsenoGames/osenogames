using UnityEngine;
using System.Collections;

public class MoveLeftandRight : MonoBehaviour 
{
	public float speed = 1.0f;

	void Update () 
	{
		//this moves the object left and right based on input and float speed
		transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
	}
}
