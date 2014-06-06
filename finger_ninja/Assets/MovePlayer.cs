using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public float distance  = 1.0f;
	public GameObject explosionPrefab;
	public GameObject ghostPrefab;
	public TrailRenderer trail;

	bool tapped = false;
	bool down = false;

	public float speed = 10.0f;
	public float timer = 0f;

	bool dead = false;
	float deathCooldown;

	public bool godMode;


	// Use this for initialization
	void Start () {
		tapped = false;
		down = false;
	}

	void Update()
	{
		if (dead) {
			deathCooldown -= Time.deltaTime;
			Debug.Log(deathCooldown);
			if (deathCooldown <= 0) {
				Debug.Log("loadlevel");
				if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0))
					Application.LoadLevel (Application.loadedLevel);
			}
	
		} else {


			if (Input.GetMouseButton (0)) {
				tapped = true;
			}
			if (Input.GetMouseButtonDown (0)) {
				trail.startWidth = 0.2f;
				trail.endWidth = 0.2f;
				down = true;
			}


			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);    
			Vector3 point = ray.origin + (ray.direction * distance);    
			Vector3 v = rigidbody2D.velocity;

			if (down && ((v.x > 0 && transform.position.x >= point.x) || (v.x < 0 && transform.position.x <= point.x))) {
				Vector3 pos = transform.position;
				pos.x = point.x;
				transform.position = pos;
				v.x = 0;
				rigidbody2D.velocity = v;
				down = false;
			}
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (dead)
			return;

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    
		Vector3 point = ray.origin + (ray.direction * distance);    


		if (down) {
			trail.startWidth = 0f;
			trail.endWidth = 0f;
			Vector3 pos = transform.position;
			pos.z = 1;
			GameObject explosion = (GameObject)Instantiate (ghostPrefab, pos, transform.rotation);
			Destroy (explosion, 2);
			down = false;
			timer = 0.3f;
		} else if(tapped)
		{
			if(timer <= 0f)
			{	trail.startWidth = 0.2f;
				trail.endWidth = 0.2f;
			}else
				timer -= Time.deltaTime;

			Vector3 pos = transform.position;
			pos.x = point.x;
			transform.position = pos;
			tapped = false;
		}

		timer -= Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (!godMode) {
			dead = true;
			deathCooldown = 0.5f;
		}
	}
}
