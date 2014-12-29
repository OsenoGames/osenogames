using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CurrentScore : MonoBehaviour 
{
	Text text;
	
	void Awake()
	{
		text = GetComponent<Text>();
	}
	
	void Start () 
	{
		text.text = "Score: " + PlayerPrefs.GetInt("Score");
	}
}
