using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
	public static int score;
	public Text ScoreText;

	// Use this for initialization
	void Start () {
		score = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = score.ToString ();

	}
	public void OnTap(){
		score++;
	}
}
