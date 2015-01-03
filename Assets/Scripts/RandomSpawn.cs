using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour 
{
	public GameObject things;
	public float minX = -10.0f;
	public float maxX = 10.0f;
	public float minY = -10.0f;
	public float maxY = 10.0f;
	public float minSpawnTime = 0.1f;
	public float maxSpawnTime = 0.5f;
	public float speed = .5f;
	public float rotation = 50.0f;


	void Start () 
	{
		Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
	}

	void SpawnNow () 
	{
		if(GameManager.Instance.gameOver == false)
		{
			if(GameManager.Instance.gameSpeed == 40f)
			{
				minSpawnTime = 0.07f;
				maxSpawnTime = 0.2f;
			}
			if(GameManager.Instance.gameSpeed == 30f)
			{
				minSpawnTime = 0.09f;
				maxSpawnTime = 0.4f;
			}
			Instantiate(things, transform.position + new Vector3(Random.Range(minX, maxX),(Random.Range(minY, maxY))),Quaternion.identity);
			Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));
		}
	}
}
