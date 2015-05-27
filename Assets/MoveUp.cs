using UnityEngine;
using System;

public class MoveUp : MonoBehaviour {
	
	public Vector2 speed = new Vector2(0.01f,0.01f);

	void Start(){
	}
	// Update is called once per frame
	void Update () {

		Vector3 Position = transform.position;
			Position.y +=speed.y;
	
		transform.position = Position;
	}
}