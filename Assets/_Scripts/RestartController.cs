using UnityEngine;
using System.Collections;

// reference to the UI namespace
using UnityEngine.UI;

// reference to manage my scenes
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour {




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ReStartButtonClick()
	{
		SceneManager.LoadScene("InDoors");

	}
}
