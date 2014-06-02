using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	// Use this for initialization
	int level;
	float timer = 0.0f;
	public GameObject shurikenPrefab;

	void Start () {
		level = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			for(int i = 0; i < level; i++)
			{
				Instantiate(shurikenPrefab, new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(7, 15), 0), Quaternion.identity);

			}
			level++;

			timer = 1.0f;

		}
	}
}
