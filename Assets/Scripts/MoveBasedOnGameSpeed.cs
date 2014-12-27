using UnityEngine;
using System.Collections;

public class MoveBasedOnGameSpeed : MonoBehaviour 
{
	public Vector3 direction;


	void Start () 
	{
	
	}
	
	void Update () 
	{
		transform.position += transform.rotation*(direction.normalized*GameManager.Instance.gameSpeed*Time.deltaTime);
	}
}
