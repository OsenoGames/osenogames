using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour 
{
	public GameObject things;
	public float minX = -10.0f;
	public float maxX = 10.0f;
	public float minY = -10.0f;
	public float maxY = 10.0f;

	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 1.0f;
	//public Quaternion rotation = Quaternion.identity;
	public float speed = .5f;
	//float nRan = 0.0f;
	//public float nRanMin = -50.0f;
	//public float nRanMax = 50.0f;


	void Start () 
	{

		Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));

	}
	void Update()
	{
		//nRan = Random.Range(nRanMin,nRanMax);
	}
	
	void SpawnNow () 
	{
		Instantiate(things, transform.position + new Vector3(Random.Range(minX, maxX),(Random.Range(minY, maxY))),Quaternion.identity);
		//Instantiate(things, transform.position + new Vector3(Random.Range(minX, maxX),(Random.Range(minY, maxY))),Quaternion.AngleAxis(nRan, Vector3.back));
		//Instantiate(things, transform.position + new Vector3(Random.Range(minX, maxX),(Random.Range(minY, maxY))),transform.eulerAngles = new Vector3(0, 10, 0));
		//transform.eulerAngles = new Vector3(0, nRan, 0);
		Invoke("SpawnNow", Random.Range(minSpawnTime, maxSpawnTime));

	}


}
