using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S4 : MonoBehaviour 
{
	Text Score4;
	void Awake () 
	{
		Score4 = GetComponent<Text>();
	}
	
	void Start () 
	{
		Score4.text = "4: " + PlayerPrefs.GetInt("H4");
	}
}
