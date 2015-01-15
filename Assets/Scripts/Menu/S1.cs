using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S1 : MonoBehaviour 
{
	public Text score1;
	public Text score2;
	public Text score3;
	public Text score4;
	public Text score5;
	//Text Score1;
	void Awake () 
	{
		//Score1 = GetComponent<Text>();
	}

	void Start () 
	{
		score1.text = "1: " + PlayerPrefs.GetInt("H1");
		score2.text = "2: " + PlayerPrefs.GetInt("H2");
		score3.text = "3: " + PlayerPrefs.GetInt("H3");
		score4.text = "4: " + PlayerPrefs.GetInt("H4");
		score5.text = "5: " + PlayerPrefs.GetInt("H5");
	}
}
