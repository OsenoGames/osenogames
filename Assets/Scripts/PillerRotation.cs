using UnityEngine;
using System.Collections;

public class PillerRotation : MonoBehaviour 
{
	public int speed = 10;

	private Transform tran;

	void Update () 
	{
		transform.Rotate(Vector3.up *speed* Time.deltaTime);
	}
}
