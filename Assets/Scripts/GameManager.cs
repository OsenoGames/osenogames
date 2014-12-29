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
	int hs1 = 0;
	int hs2 = 0;
	int hs3 = 0;
	int hs4 = 0;
	int hs5 = 0;
	int scin = 0;


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
		scin = (int)score;
		if(scin >= hs1)
		{
			PlayerPrefs.SetInt("H5", hs4);
			PlayerPrefs.SetInt("H4", hs3);
			PlayerPrefs.SetInt("H3", hs2);
			PlayerPrefs.SetInt("H2", hs1);
			PlayerPrefs.SetInt("H1", scin);
			PlayerPrefs.Save();
			scin = 0;
		}
		if(scin >= hs2)
		{
			PlayerPrefs.SetInt("H5", hs4);
			PlayerPrefs.SetInt("H4", hs3);
			PlayerPrefs.SetInt("H3", hs2);
			PlayerPrefs.SetInt("H2", scin);
			PlayerPrefs.Save();
			scin = 0;
		}
		if(scin >= hs3)
		{
			PlayerPrefs.SetInt("H5", hs4);
			PlayerPrefs.SetInt("H4", hs3);
			PlayerPrefs.SetInt("H3", scin);
			PlayerPrefs.Save();
			scin = 0;
		}
		if(scin >= hs4)
		{
			PlayerPrefs.SetInt("H5", hs4);
			PlayerPrefs.SetInt("H4", scin);
			PlayerPrefs.Save();
			scin = 0;
		}
		if(scin >= hs5)
		{
			PlayerPrefs.SetInt("H5", scin);
			PlayerPrefs.Save();
			scin = 0;
		}
		//PlayerPrefs.SetInt("HighScore", (int)highScore);
		//PlayerPrefs.Save();
	}
	void LoadHighScore()
	{
		highScore = PlayerPrefs.GetInt("HighScore");
		hs1 = PlayerPrefs.GetInt("H1",0);
		hs2 = PlayerPrefs.GetInt("H2",0);
		hs3 = PlayerPrefs.GetInt("H3",0);
		hs4 = PlayerPrefs.GetInt("H4",0);
		hs5 = PlayerPrefs.GetInt("H5",0);
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
