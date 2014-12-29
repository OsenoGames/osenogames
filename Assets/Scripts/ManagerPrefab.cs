using UnityEngine;
using System.Collections;

public class ManagerPrefab : MonoBehaviour 
{
	public GameObject PlayerPrefab;

	void Awake () 
	{
		GameObject gamemanager = Instantiate(PlayerPrefab, Vector3.zero, Quaternion.identity)as GameObject;
		gamemanager.name = "GameManager";
	}
}
