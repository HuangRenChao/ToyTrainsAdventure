using UnityEngine;
using System.Collections;

public class PhysicsRayCaster : MonoBehaviour {

	private RaycastHit hit;
	private Vector3 forward;

	public bool debugRay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(debugRay){
			DrawRay ();
		}
	}

	void DrawRay () {
		
		float theDistance;
		forward = transform.TransformDirection (Vector3.forward) * 100;

		Debug.DrawRay (transform.position, forward, Color.green);

		if(Physics.Raycast(transform.position, (forward), out hit)){
			theDistance = hit.distance;
			print (theDistance + " " + hit.collider.gameObject.name + " " + hit.point);
		}
	}

	public Vector3 RayHitPoint(){
		forward = transform.TransformDirection (Vector3.forward) * 10;

		if(Physics.Raycast(transform.position, (forward), out hit)){
			return hit.point;
		} else{
			return Vector3.zero;
		}



	}



}
