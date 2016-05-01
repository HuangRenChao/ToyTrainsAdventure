using UnityEngine;
using System.Collections;

public class TrainCollisionDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision collision){
		Debug.Log ("Collision!");
		GameObject train = GameObject.Find ("Train");
		LeanTween.cancel (train);
	}
}
