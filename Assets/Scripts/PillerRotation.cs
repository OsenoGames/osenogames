using UnityEngine;
using System.Collections;

public class PillerRotation : MonoBehaviour 
{
	public int speed = 10;

	void Update () 
	{
		if(GameManager.Instance.gameOver == false)
		{
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
	}
}
