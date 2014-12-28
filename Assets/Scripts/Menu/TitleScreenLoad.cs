using UnityEngine;
using System.Collections;

public class TitleScreenLoad : MonoBehaviour 
{
	public bool startLevel = false;

	public void Click1(bool startLevel)
	{
		if(startLevel)
			Application.LoadLevel("TitleScreen");
	}

}
