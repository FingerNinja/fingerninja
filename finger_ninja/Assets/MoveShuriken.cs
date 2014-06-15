using UnityEngine;
using System.Collections;

public class MoveShuriken : MonoBehaviour {

	public static int ZIGZAG = 2;
	public static int STRAIGHT_DOWN = 1;

	// Use this for initialization
	public float speed = 10.0f;
	public int moveType;

	public Vector3 originalPosition;

	void Start () {
		rigidbody2D.gravityScale = 2;
		speed = Random.Range (5, 10);

		Debug.Log (transform.position.y);
		if (transform.position.y > 6)
			originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 v = rigidbody2D.velocity;



//		v.y = -speed;
//		int val = Random.Range (0, 2);
//
//
//		if (val == 0) {
//
//		}
//		else {
//		Vector3 pos = new Vector3( Mathf.Sin(transform.position.y) + originalPosition.x, transform.position.y);
//			transform.position = pos;
//		}
		rigidbody2D.velocity = v;

	}
}
