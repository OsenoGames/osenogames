using UnityEngine;
using System.Collections;

public class LoadLevel2 : MonoBehaviour 
{
	public bool startLevel = false;

	public void Click1(bool startLevel)
	{
		if(startLevel)
			Application.LoadLevel("Level2");
	}

}
