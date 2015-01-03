using UnityEngine;
using System.Collections;

public class ScaleOverTime : MonoBehaviour
{
	public Vector3 finalScale = Vector3.zero;
	public float time = 3.0f;

	private Vector3 initialScale;

	// Use this for initialization
	void Start ()
	{
		initialScale = transform.localScale;
		StartCoroutine("Scale");
	}
	
	IEnumerator Scale()
	{
		float t = 0.0f;

		while(t <= time)
		{
			if(GameManager.Instance.gameSpeed == 40f)
			{
				time = 0.5f;
			}
			if(GameManager.Instance.gameSpeed == 30f)
			{
				time = 1.5f;
			}
			if(GameManager.Instance.gameOver)
			{
				time = 0.001f;
			}
			transform.localScale = Vector3.Lerp(initialScale,finalScale,t/time);
			t += Time.deltaTime;
			yield return null;
		}

		transform.localScale = finalScale;
	}
}
