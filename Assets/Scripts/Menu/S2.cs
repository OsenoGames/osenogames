using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S2 : MonoBehaviour 
{
	Text Score2;
	void Awake () 
	{
		Score2 = GetComponent<Text>();
	}
	
	void Start () 
	{
		Score2.text = "2: " + PlayerPrefs.GetInt("H2");
	}
}

