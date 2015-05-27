using UnityEngine;
using System;

public class PlayerControler : MonoBehaviour {

	public Vector2 speed = new Vector2(0.05f,0.05f);
	bool jumping=false;
	public float jumpV =10.0f;
	public LayerMask groundlayer;

	void Start(){
	}
	// Update is called once per frame
	void Update () {
		jumping = Physics2D.Linecast (transform.position, transform.position - transform.up , groundlayer);

		Vector3 Position = transform.position;
		if (Input.GetKey ("left")) {
			Position.x -=speed.x;
		}
		if (Input.GetKey ("right")) {
			Position.x +=speed.x;
		}
		if (jumping && Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody2D>().AddForce(Vector3.up*300);
		}
		transform.position = Position;
	}
}