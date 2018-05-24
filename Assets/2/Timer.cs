using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text ScoreText;
	private float timer;
	public static bool TimerOn;
	// Use this for initialization
	void Start () {
		timer = 0;
		TimerOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = timer.ToString ("F4");

		if (TimerOn == true) {
			timer += Time.deltaTime;
		}
	}
	public void OnTap(){
		if (TimerOn == false)
			TimerOn = true;
		else
			TimerOn = false;
	}
}
