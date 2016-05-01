using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float movingDistancePerUpdate = 1f;

	private CardboardHead head;

	// Use this for initialization
	void Start () {
		head = GameObject.FindObjectOfType<CardboardHead> ();

	}
	
	// Update is called once per frame
	void Update () {
		MoveToDirection (LookDirection (), movingDistancePerUpdate);

	}


	void OnCollisionStay(Collision collision) {
		
        foreach (ContactPoint contact in collision.contacts) {
        	if (collision.gameObject.name == "Surface"){
				Debug.DrawRay(contact.point, contact.normal * 10, Color.red);
        	} else if(collision == null){
				Debug.DrawRay(contact.point, contact.normal * 10, Color.blue);
				InitiateRail ();
        	}   	            
    	}
    }

	void MoveToDirection(Vector3 lookDirection, float movingDistance){
		GameObject player = GameObject.Find ("Player");


	}

	void InitiateRail(){
		RailSpawner railSpawner = GameObject.FindObjectOfType<RailSpawner> ();
		railSpawner.InstantiateRail (0, 0f);
	}

	public Vector3 LookDirection() {
		return Vector3.ProjectOnPlane (head.Gaze.direction, Vector3.up);
//		return head.Gaze.direction;
	}

	public Vector3 PlayerRotation() {
		return head.transform.rotation.eulerAngles;
	}


	void OnCollisionEnter (Collision collision) {
		Debug.Log ("Player's Collision!");
	}

}
