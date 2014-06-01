using UnityEngine;
using System.Collections;

public class Disapear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Color c = renderer.material.color;
		c.a -= Time.deltaTime*5;
		renderer.material.color = c;
	}
}
