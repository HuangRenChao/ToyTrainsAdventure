using UnityEngine;
using System.Collections;

public class ToysWantRide : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col){
		if(col.gameObject.tag == "Train"){
			Debug.Log ("TakeOnTrain!");
			if(CountToysOnTrain() < 1){
				TakeOnTrain (gameObject);
			}

		} 

	}

	void TakeOnTrain(GameObject toysWantRide){
		GameObject trainGroup = GameObject.Find("TrainGroup");
		GameObject train = GameObject.Find ("Train");

		train.gameObject.tag = "TrainWithToy";
		toysWantRide.gameObject.tag = "ToysOnTrain";
		toysWantRide.transform.position = trainGroup.transform.position + Vector3.up;
		toysWantRide.transform.parent = trainGroup.transform;
	}



	void StartTrain(){
		PathMove pathMove = GameObject.FindObjectOfType<PathMove> ();
		pathMove.MoveTrain ();
	}

	int CountToysOnTrain(){
		int toysOnTrainNumber =	GameObject.FindGameObjectsWithTag ("ToysOnTrain").Length;
		return toysOnTrainNumber;
	}
}
