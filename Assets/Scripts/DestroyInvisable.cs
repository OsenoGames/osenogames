using UnityEngine;
using System.Collections;

public class DestroyInvisable : MonoBehaviour 
{
	void onBecameInvisable()
	{
		Destroy (gameObject);
	}

}
