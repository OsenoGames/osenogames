using UnityEngine;
using System.Collections;

public class LeftandRight : MonoBehaviour 
{
	public float speed = 1.0f;

	void Update () 
	{
		if(GameManager.Instance.gameOver == false)
		{
			renderer.material.mainTextureOffset += Vector2.right*Input.GetAxis("Horizontal")*speed * Time.deltaTime;
		}
	}
}
