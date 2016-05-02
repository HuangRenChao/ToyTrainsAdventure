using UnityEngine;
using System.Collections;

public class MovingObstacle : MonoBehaviour {

	public float speed = 1f;
	public Transform goal;
	// Use this for initialization


	void Start () {
		NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.destination = goal.position;
	}
	
	// Update is called once per frame
	void Update () {
			

	}

	public void Move(float speed) {
		
		transform.Translate (Vector3.right * speed * Time.deltaTime, Space.Self);	
				

	}



}
