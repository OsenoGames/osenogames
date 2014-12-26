using UnityEngine;
using System.Collections;

public class DestroyOffMap : MonoBehaviour 
{
	public float destroyValue = 0.0f;

	void Update () 
	{
		if(transform.position.z <= destroyValue)
		{
			Destroy (gameObject);
		}
	}
}
