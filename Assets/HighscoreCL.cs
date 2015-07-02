using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighscoreCL : MonoBehaviour {
	
	public GameObject target;
	private float higth;
	private float highest=0.0f;
	Text text;
	public int fenshu;
	
	
	void Start () {
		text = GetComponent <Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		higth = target.transform.position.y;
		if (highest <= higth)
			highest = higth;
		
		fenshu = (int)highest;
		text.text = "High Score:" + fenshu;
	}

	void setscore(){

	}
}

