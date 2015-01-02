using UnityEngine;
using System.Collections;

public class AnamateTexture : MonoBehaviour 
{
	public Vector2 speed = Vector2.one;
	string mve;

	void Update () 
	{
		if(GameManager.Instance.gameOver == false)
		{
			renderer.material.mainTextureOffset += speed * Time.deltaTime;
		}
	}
}
