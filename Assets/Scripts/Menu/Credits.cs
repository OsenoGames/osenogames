using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour 
{
	public bool startLevel = false;

	public void Click1(bool startLevel)
	{
		if(startLevel)
			Application.LoadLevel("Credits");
	}

}
