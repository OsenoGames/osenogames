using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S1 : MonoBehaviour 
{
	Text Score1;
	void Awake () 
	{
		Score1 = GetComponent<Text>();
	}

	void Start () 
	{
		Score1.text = "1: " + PlayerPrefs.GetInt("H1");
	}
}
