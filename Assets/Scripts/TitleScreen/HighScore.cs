using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour 
{

	Text text;

	void Awake()
	{
 		text = GetComponent<Text>();

	}

	void Start () 
	{
		text.text = "Highscore: " + PlayerPrefs.GetInt("HighScore");
	}
}
