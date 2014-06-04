using UnityEngine;
using System.Collections;

public class MoveShuriken : MonoBehaviour {

	public static int ZIGZAG = 2;
	public static int STRAIGHT_DOWN = 1;

	// Use this for initialization
	public float speed = 10.0f;
	public int moveType;

	void Start () {

		speed = Random.Range (5, 10);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 v = rigidbody2D.velocity;
		v.y = -speed;
		int val = Random.Range (0, 2);
		if (val == 0)
			v.x = speed;
		else {
			v.x = -speed;
		}
		rigidbody2D.velocity = v;
	}
}
