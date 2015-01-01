using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour 
{
	public float speed;
	bool doOnce = true;

	void Update () 
	{

		if(Input.GetKey(KeyCode.A))
		{
			if(doOnce)
			{
				transform.Rotate(new Vector3(0,0,-90*speed));
				doOnce = false;
			}
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			transform.Rotate(new Vector3(0,0,90*speed));
			doOnce= true;
		}
		if(Input.GetKey(KeyCode.D))
		{
			if(doOnce)
			{
				transform.Rotate(new Vector3(0,0,90*speed));
				doOnce = false;
			}
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			transform.Rotate(new Vector3(0,0,-90*speed));
			doOnce = true;
		}
	}
}
