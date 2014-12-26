using UnityEngine;
using System.Collections;

public class AnamateTexture : MonoBehaviour 
{
	public Vector2 speed = Vector2.one;
	string mve;

	void Start () 
	{
	
	}
	
	void Update () 
	{
	renderer.material.mainTextureOffset += speed * Time.deltaTime;
	}
}
