using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public static int VERTICAL = 0;
	public static int HORIZONTAL = 1;
	public static int DIAGONAL = 2;

	// Use this for initialization
	int level;
	float timer = 0.0f;
	float totalTime = 0.0f;
	public GameObject shurikenPrefab;


	void Start () {
		level = 0;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer -= Time.deltaTime;
		totalTime += Time.deltaTime;
		if (timer <= 0) {

			int r = Random.Range(0, 3);

			GameObject player = GameObject.FindGameObjectWithTag("Player");
			if(player != null)
			{
				float k = player.transform.position.x;
				switch(r)
				{
					case 0:
						k = Random.Range(-3f, 3f);
						Instantiate(shurikenPrefab, new Vector3(k, 7, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k, 8, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k, 9, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k, 10, 0), Quaternion.identity);
						break;
					case 1:
						//k = Random.Range(-1f, 1f);
						Instantiate(shurikenPrefab, new Vector3(k-1f, 8, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k-0.5f, 8, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k, 8, 0), Quaternion.identity);
//						Instantiate(shurikenPrefab, new Vector3(k+0.5f, 8, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k+1f, 8, 0), Quaternion.identity);
						break;
					case 2:
						//k = Random.Range(-3f, 3f);
						Instantiate(shurikenPrefab, new Vector3(k-1f, 7, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k-0.5f, 8, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k, 9, 0), Quaternion.identity);	
//						Instantiate(shurikenPrefab, new Vector3(k+0.5f, 10, 0), Quaternion.identity);
//						Instantiate(shurikenPrefab, new Vector3(k+1f, 11, 0), Quaternion.identity);
						break;
				}

				timer = Random.Range(0.3f, 0.6f);


				level = (int)Mathf.Floor(totalTime / 5.0f);
				//MoveShuriken.speed = Random.Range(1, 10) + level * 2.0f;
			}
		}
	}
}
