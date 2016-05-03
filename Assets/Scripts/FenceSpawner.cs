using UnityEngine;
using System.Collections;

public class FenceSpawner : MonoBehaviour {

	public GameObject userFencePrefab;

	private Player player;
	private PhysicsRayCaster physicsRayCaster;

	// Use this for initialization
	void Start () {
		Cardboard.SDK.OnTrigger += PullTrigger;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InstantiateFence(){
		GameObject userFenceObject = Instantiate (userFencePrefab);
		player = GameObject.FindObjectOfType<Player> ();
		physicsRayCaster = GameObject.FindObjectOfType<PhysicsRayCaster> ();

		Vector3 placePosition = Vector3.ProjectOnPlane(physicsRayCaster.RayHitPoint(), Vector3.up);
//		Vector3 playerRotation = player.PlayerRotation ();


		userFenceObject.transform.position = placePosition;
//		userFenceObject.transform.rotation = Quaternion.Euler (playerRotation);
		userFenceObject.transform.parent = transform;


	}

	void PullTrigger () {
		InstantiateFence ();
	}

}
