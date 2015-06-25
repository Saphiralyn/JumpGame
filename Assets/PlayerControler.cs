using UnityEngine;
using System;

public class PlayerControler : MonoBehaviour {

	public Vector2 speed = new Vector2(0.05f,0.0f);
	bool jumping=false;
	public float jumpV =10.0f;
	public LayerMask groundlayer;
	public Collider2D ground;
	int screenwidth=Screen.width;
	float highest;

	
	void Start(){
		highest = transform.position.y;
	}
	// Update is called once per frame
	void Update () {
		if (highest < transform.position.y)
			highest = transform.position.y;

		jumping = Physics2D.Linecast (transform.position, transform.position - transform.up + transform.right, groundlayer);
	
		Vector3 Position = transform.position;
		if (Input.GetKey ("left")) {
			Position.x -=speed.x;
		}
		if (Input.GetKey ("right")) {
			Position.x +=speed.x;
		}

		/*if (Input.GetMouseButton (0)) {
			if (Input.mousePosition.x > screenwidth / 2) {
				Position.x += speed.x;
			} else
				Position.x -= speed.x;
		}*/


		if (jumping && Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.up * 350);
		}
	
	if (transform.position.y < highest - 5.0f)
			Application.LoadLevel (Application.loadedLevelName);
	
		this.transform.position = Position;
	}
}