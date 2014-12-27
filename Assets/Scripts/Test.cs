using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
	public float yRotation = 5.0F;
	void Update() 
	{
		yRotation += 50;
		yRotation += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(10, yRotation, 0)*Time.deltaTime;
	}
}
