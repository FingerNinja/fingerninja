using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0;

	MovePlayer ninja;
	MoveShuriken shuriken;
	
	static Score instance;
	
	static public void AddPoint(){
		if (!instance.ninja.dead) {
			score++;
			if (score > highScore)
				highScore = score;
		}
	}

	// Use this for initialization
	void Start () {
		instance = this;
		instance.ninja = GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer>();

		score = 0;
//		highScore = PlayerPrefs.GetInt ("HighScore", 0);
//		highScore = 0;
	}

	void OnDestroy(){
//		PlayerPrefs.SetInt ("HighScore", highScore);
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + score + "\nHighScore: "+ highScore ;
	}
}
