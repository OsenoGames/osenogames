using UnityEngine;
using System.Collections;

public class LeftandRight : MonoBehaviour 
{
	public float speed = 1.0f;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		renderer.material.mainTextureOffset += Vector2.right*Input.GetAxis("Horizontal")*speed * Time.deltaTime;
	}
}
