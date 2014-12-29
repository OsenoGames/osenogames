using UnityEngine;
using System.Collections;

public class PillerRotation : MonoBehaviour 
{
	//public float rotOffset = 50.0f; 
	public int speed = 10;

	private Transform tran;

	void Start () 
	{

	}
	
	void Update () 
	{
		transform.Rotate(Vector3.up *speed* Time.deltaTime);
	}
}
