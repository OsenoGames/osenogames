using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour 
{
	public GameObject gibs;

	void OnTriggerEnter()
	{
		Instantiate(gibs,transform.position,Quaternion.identity);
		Destroy(gameObject);
	}
}
