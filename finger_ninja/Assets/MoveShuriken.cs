using UnityEngine;
using System.Collections;

public class MoveShuriken : MonoBehaviour {

	public static int ZIGZAG = 2;
	public static int STRAIGHT_DOWN = 1;

	// Use this for initialization
	float speed = 7.0f;
	public int moveType;

	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 v = rigidbody2D.velocity;
		v.y = -speed;
		rigidbody2D.velocity = v;
	}
}
