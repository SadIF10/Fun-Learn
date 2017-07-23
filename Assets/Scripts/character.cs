using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character : MonoBehaviour {

	public AudioSource sound;
	public AudioClip a;
	public AudioClip b;
	public AudioClip c;
	public AudioClip d;
	int count = 41;
	// Use this for initialization

	void Start () {
		Input.gyro.enabled = true;
		playit ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.gyro.rotationRateUnbiased.y > 60) {
			left ();
		}
	}

	public void playit() {
		if (count % 4 == 1) {
			sound.clip = a;
			sound.Play();
		}
		if (count % 4 == 2) {
			sound.clip = b;
			sound.Play ();
		}
		if (count % 4 == 3) {
			sound.clip = c;
			sound.Play();
		}
		if (count % 4 == 0) {
			sound.clip = d;
			sound.Play();
		}
	}

	public void left() {
		count--;
		playit ();
		transform.Rotate (0,90,0);
	}

	public void right() {
		count++;
		playit ();
		transform.Rotate (0,-90,0);
	}

	public void menu() {
		SceneManager.LoadScene ("menu");
	}
}