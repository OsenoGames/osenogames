using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S5 : MonoBehaviour 
{
	Text Score5;
	void Awake () 
	{
		Score5 = GetComponent<Text>();
	}
	
	void Start () 
	{
		Score5.text = "2: " + PlayerPrefs.GetInt("H5");
	}
}
