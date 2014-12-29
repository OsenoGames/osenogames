using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public float pointPerUnit = 1.0f;
	public static GameManager Instance;
	public float gameSpeed = 20.0f;
	public string titleScreenName = "TitleScreen";


	private static float highScore = 0.0f;
	private bool gameOver = false;
	private float score = 0.0f;
	private bool hasSaved = false;


	void Start () 
	{
		if(Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		LoadHighScore();
		//DontDestroyOnLoad(gameObject);
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
				SaveScore();
			}
			else
			{
				SaveScore();
			}
			if(Input.anyKeyDown)
			{
				Application.LoadLevel(titleScreenName);
			}

		}

	}
	void SaveScore()
	{
		PlayerPrefs.SetInt("Score", (int)score);
		PlayerPrefs.Save();
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
		GUILayout.Label("Score: " + ((int)score).ToString());
		GUILayout.Label("High Score: " + ((int)highScore).ToString());
		if(gameOver == true)
		{
			GUILayout.Label("Game Over!  Press any key to quit...");
		}
	}
}
