
using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
	public float yRotation = 5.0F;
	void Update() 
	{
		//yRotation = 0.0f;
		yRotation += Input.GetAxis("Horizontal");
		yRotation += 50;
		yRotation += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(0, yRotation, 0)*Time.deltaTime;
	}
}
