using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {
	private GameObject playAgain;

	public bool isGameOver;

	// Use this for initialization
	void Start () {
		playAgain = GameObject.Find ("PlayAgain");

		playAgain.gameObject.SetActive (false);
		isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void LateUpdate(){
		if(isGameOver){
			playAgain.gameObject.SetActive (true);


		}
	}


	public void RestartScene(){
		SceneManager.LoadScene ("Game");
	}



}
