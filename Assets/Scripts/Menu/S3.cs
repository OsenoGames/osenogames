using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S3 : MonoBehaviour 
{
	Text Score3;
	void Awake () 
	{
		Score3 = GetComponent<Text>();
	}
	
	void Start () 
	{
		Score3.text = "3: " + PlayerPrefs.GetInt("H3");
	}
}
