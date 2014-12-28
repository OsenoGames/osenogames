using UnityEngine;
using System.Collections;

public class HighscoreLoad : MonoBehaviour 
{
	public bool startLevel = false;

	public void Click1(bool startLevel)
	{
		if(startLevel)
		Application.LoadLevel("HighScore");
	}

}
