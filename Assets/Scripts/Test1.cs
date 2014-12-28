using UnityEngine;
using System.Collections;

public class Test1 : MonoBehaviour 
{
	public float yRotation = 50.0f;
	void Update() 
	{
		yRotation = 30f;
		yRotation += Input.GetAxis("Horizontal");
		Rotation();
	}

	void Rotation()
	{
		transform.eulerAngles = new Vector3(10, yRotation, 0) *Time.deltaTime;
		//WaitForSeconds(5);
	}
}
