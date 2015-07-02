using UnityEngine;
using System;

public class MoveUp : MonoBehaviour {
	
	public Vector2 speed = new Vector2(0.01f,0.01f);
	public float posY=0.0f;

	void Start(){
	}
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 Position = transform.position;
			Position.y +=speed.y;
	
		transform.position = Position;
		posY = this.transform.position.y;
	}
}