using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public GUIStyle labStyle1;
	public GUIStyle labStyle2;
	public static GameManager Instance;
	public bool gameOver = false;
	public float gameSpeed = 20.0f;

	float pointPerUnit = 5.0f;
	float highScore = 0.0f;
	float score = 0.0f;
	int hs1 = 0; int hs2 = 0; int hs3 = 0;
	int hs4 = 0; int hs5 = 0;
	int speedTimer = 0;

	void Awake () 
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
		highScore = hs1;
	}
	void Update () 
	{
		speedTimer += 1;
		if(speedTimer == 500)
		{
			Time.timeScale += 0.1F;
			Time.fixedDeltaTime = 0.02F * Time.timeScale;
			speedTimer = 0;
		}
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
			Time.timeScale = 1.0F;
			Time.fixedDeltaTime = 0.02F * Time.timeScale;
			SaveScore();
			SaveHighScore();
		}
	}
	void SaveScore()
	{
		PlayerPrefs.SetInt("Score", (int)score);
		PlayerPrefs.Save();
	}
	void SaveHighScore()
	{
		int scin = (int)score;
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
	}
	void LoadHighScore()
	{
		hs1 = PlayerPrefs.GetInt("H1",0);
		hs2 = PlayerPrefs.GetInt("H2",0);
		hs3 = PlayerPrefs.GetInt("H3",0);
		hs4 = PlayerPrefs.GetInt("H4",0);
		hs5 = PlayerPrefs.GetInt("H5",0);
	}
	void OnGUI()
	{
		GUI.Label(new Rect(10,10,250,45),"Score: " + (int)score,labStyle2);
		GUI.Label(new Rect(Screen.width / 2- 75,10,250,45),"High Score: " + (int)highScore,labStyle2);

		if(gameOver == true)
		{
			GUI.Label(new Rect(Screen.width / 2 - 150,100,300,100),"Game Over!", labStyle1);
			//GUI.Label(new Rect(Screen.width / 2 - 200,185,400,100),"Score: " + (int)score, labStyle1);

			if(GUI.Button(new Rect(Screen.width / 2 - 75,310,150,75), "Restart Level"))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button(new Rect(Screen.width / 2 - 75,400,150,75), "Main Menu"))
			{
				Application.LoadLevel("TitleScreen");
			}

		}
	}
}
