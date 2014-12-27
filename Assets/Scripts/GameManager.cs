using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public static GameManager Instance;
	private static float highScore = 0.0f;
	public float pointPerUnit = 1.0f;
	private bool gameOver = false;
	private float score = 0.0f;
	public float gameSpeed = 20.0f;
	private bool hasSaved = false;
	void Start () 
	{
		Instance = this;
		LoadHighScore();
	}
	
	void Update () 
	{
		if(!gameOver)
		{
			score += pointPerUnit*gameSpeed*Time.deltaTime;
			if(score>highScore)
			{
				highScore = score;
			}
		}

		if(GameObject.FindGameObjectWithTag("Player") == null)
		{
			gameOver = true;

		}
		if(gameOver)
		{
			if(!hasSaved)
			{
				SaveHighScore();
			}
			if(Input.anyKeyDown)
			{
				Application.LoadLevel(Application.loadedLevel);
			}

		}

	}

	void SaveHighScore()
	{
		PlayerPrefs.SetInt("HighScore", (int)highScore);
		PlayerPrefs.Save();
	}
	void LoadHighScore()
	{
		highScore = PlayerPrefs.GetInt("HighScore");
	}

	void OnGUI()
	{
		//int currentScore = (int)score;
		//GUI.Label(new Rect(10, 10, 50, 25), "Name: ");
		//GUI.Label(new Rect(50, 50, 100, 25), "Score " + currentScore.ToString());
		GUILayout.Label("Score: " + ((int)score).ToString());
		GUILayout.Label("High Score: " + ((int)highScore).ToString());
		if(gameOver == true)
		{
			GUILayout.Label("Game Over!  Press any key to restart...");
		}
	}
}
