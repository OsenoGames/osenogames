using UnityEngine;
using System.Collections;

public class PlayerOnTrigger : MonoBehaviour 
{
	public GameObject gibs;

	void OnTriggerEnter()
	{
		Instantiate(gibs,transform.position,Quaternion.identity);
		Destroy(gameObject);
	}
}
