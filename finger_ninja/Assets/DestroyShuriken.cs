using UnityEngine;
using System.Collections;

public class DestroyShuriken : MonoBehaviour {

	GameObject player_go;

	// Use this for initialization
	void Start () {
		player_go = GameObject.FindGameObjectWithTag ("Player").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject != player_go)
			Destroy (collider.gameObject);
	}
}
