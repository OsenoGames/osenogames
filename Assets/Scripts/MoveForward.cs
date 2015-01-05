using UnityEngine;
using System.Collections;
public class MoveForward : MonoBehaviour
{
	public float speed = 1.0f;

	void Update()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}