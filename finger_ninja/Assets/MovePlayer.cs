using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public float distance  = 1.0f;
	public GameObject explosionPrefab;
	public GameObject ghostPrefab;

	bool tapped = false;
	bool down = false;
	// Use this for initialization
	void Start () {
		tapped = false;
		down = false;
	}

	void Update()
	{

		if (Input.GetMouseButton (0)) {
			tapped = true;
		}
		if (Input.GetMouseButtonDown (0)) {
			down = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if(down){
			Vector3 pos = transform.position;
			pos.z = 1;
			GameObject explosion = (GameObject)Instantiate(ghostPrefab, pos, transform.rotation);
			Destroy (explosion, 2);
			down = false;
		}

		if(tapped)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    
			Vector3 point = ray.origin + (ray.direction * distance);    

			Vector3 pos = transform.position;
			pos.x = point.x;
			transform.position = pos;
			tapped = false;
		}

	}
}
