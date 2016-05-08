using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TrainCollisionDetect : MonoBehaviour {

	private GameObject playAgain;
	private SceneControl sceneControl;

	// Use this for initialization
	void Start () {
		sceneControl = GameObject.FindObjectOfType<SceneControl> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision collision){
		GameObject trainGroup = GameObject.Find ("TrainGroup");
		if(collision.gameObject.tag == "Train" || collision.gameObject.tag == "TrainWithToy"){
			
			LeanTween.cancel (trainGroup);
			sceneControl.isGameOver = true;



		}

	}
}
