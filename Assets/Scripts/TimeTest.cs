using UnityEngine;
using System.Collections;

public class TimeTest : MonoBehaviour 
{
	float gameTime;
	int totalHours;
	int totalMin;
	int totalSec;
	bool oneTime = true;

	void Start () 
	{
	gameTime = 0.0f;
	}
	
	void Update () 
	{
		if(GameManager.Instance.gameOver)
		{
			if(oneTime)
			{
				oneTime = false;
				TotalTime();

			}
		}
	}

	void TotalTime()
	{
		gameTime = Time.time;
		Debug.Log("Total Time " + gameTime);
		totalHours = (int)gameTime / 3600;
		gameTime = gameTime - totalHours * 3600;
		totalMin = (int)gameTime / 60;
		totalSec = (int)gameTime - (int)totalMin * 60;
		
		Debug.Log("Total Hours " + totalHours);
		Debug.Log("Total Mins " + totalMin);
		Debug.Log("Total Secs " + totalSec);
	}
	void OnGUI(){
		if(GameManager.Instance.gameOver)
			GUILayout.Label(string.Format("{0:00}:{1:00} with",totalMin + (totalHours), totalSec));
	}
		

}
