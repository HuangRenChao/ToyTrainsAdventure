using UnityEngine;
using System.Collections;

public class TargetGround : MonoBehaviour {

	public int toysMovedCount = 0;
	public Transform[] placePositions;
	public int occupiedPlaceCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){
		if(col.gameObject.tag == "TrainWithToy"){
			Debug.Log ("DropoffTarget!");
			GameObject toysOnTrain = GameObject.FindGameObjectWithTag("ToysOnTrain");
			DropOffTarget (toysOnTrain);
		} 

	}
	void DropOffTarget(GameObject toysOnTrain){
		GameObject targetGround = GameObject.Find ("TargetGround");
		GameObject train = GameObject.Find ("Train");
		int placePositionLength = placePositions.Length;

		train.gameObject.tag = "Train";

		if(occupiedPlaceCount <= placePositionLength) {
			toysOnTrain.transform.position = placePositions [occupiedPlaceCount].position;
			occupiedPlaceCount++;
		} else {
			occupiedPlaceCount = 0;
		}


		toysOnTrain.transform.parent = targetGround.transform;
		toysOnTrain.transform.tag = "ToysInTarget";
		toysOnTrain.GetComponent<SphereCollider> ().enabled = false;
		toysMovedCount++;
}


}
