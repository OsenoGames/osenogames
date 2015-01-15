using UnityEngine;
using System.Collections;

public class LevelLoad : MonoBehaviour 
{

	public bool startLevel = false;
		
	public void Click1(bool startLevel)
	{
		if(startLevel)
			Application.LoadLevel("LevelSelect");
	}

}
