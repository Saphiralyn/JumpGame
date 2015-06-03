using UnityEngine;
using System.Collections;

public class Treelife : MonoBehaviour {
	private float life=10.0f;

	void Start () {
	 //life=10.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		life -= Time.deltaTime;
		if (life < 0)
			Destroy (this.gameObject);
	
	}
}
