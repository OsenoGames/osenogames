using UnityEngine;
using System.Collections;

public class PillerRotation : MonoBehaviour 
{
	public int speed = 10;

	void Start()
	{
		//speed = Random(1, 100);
		//transform.RotateAround(Vector3)
	}
	void Update () 
	{
		if(GameManager.Instance.gameOver == false)
		{
			//transform.RotateAround(Vector3.up, 1 * Time.deltaTime);
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
	}
}
