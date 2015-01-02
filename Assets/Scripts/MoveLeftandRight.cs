using UnityEngine;
using System.Collections;

public class MoveLeftandRight : MonoBehaviour 
{
	public float speed = 1.0f;

	void Update () 
	{
		if(GameManager.Instance.gameOver == false)
		{
			transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
		}
	}
}
