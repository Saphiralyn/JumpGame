using UnityEngine;
using System.Collections;

public class Wallmovement : MonoBehaviour {
	GameObject reimu;
	public float smoothing =1f;
	void Start () {
     
		reimu =	GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y<reimu.transform.position.y)
			//transform.position= Vector2.Lerp(reimu.transform.position, transform.position, smoothing * Time.deltaTime);
			transform.position = new Vector3(transform.position.x, reimu.transform.position.y, transform.position.z);
	}
}
