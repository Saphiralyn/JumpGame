﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public GameObject target;
	private float higth;
	private float highest=0.0f;
	Text text;
	private int fenshu;
	static private int highscore;


	void Start () {
		text = GetComponent <Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		higth = target.transform.position.y;
		if (highest <= higth)
			highest = higth;
	if(highscore<higth)
			highscore=(int)higth;
		fenshu = (int)highest;
		text.text = "Score:" + fenshu+"\n"+"HighSocre:"+highscore;
	}
}



