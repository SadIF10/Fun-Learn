using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void abc() {
		SceneManager.LoadScene ("ABC");
	}

	public void numbers() {
		SceneManager.LoadScene("123");
	}

	public void rhymes() {

	}

	public void exit() {
		Application.Quit ();
	}
}
