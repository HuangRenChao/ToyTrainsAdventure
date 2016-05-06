using UnityEngine;
using System.Collections;

public class PassengerSpawner : MonoBehaviour {

	public GameObject passengerPrefab;
	public Transform[] spawnPositions;
	public float spawnPeriodInSecs;
	public float remainingTimeInSecs;

	private int randomIndex;

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawn ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Spawn(){
		while (true){
			WaitForSeconds waitInSecs = new WaitForSeconds (spawnPeriodInSecs);
			yield return waitInSecs;

			InstantiatePassenger ();
		}
	}

	IEnumerator DestroyPassenger(GameObject passenger){
		while (true){
			WaitForSeconds waitInSecs = new WaitForSeconds (remainingTimeInSecs);
			yield return waitInSecs;

			if(passenger.gameObject.tag == "ToysWantRide"){
				Destroy (passenger);
			}

		}
	}



	Vector3 RandomPosition(){
		randomIndex = Random.Range (0, 10);
		return spawnPositions [randomIndex].position;
	}

	void InstantiatePassenger(){
		GameObject passenger = Instantiate (passengerPrefab);
		passenger.transform.position = RandomPosition ();
		passenger.transform.parent = transform;

		StartCoroutine(DestroyPassenger(passenger));


	}

}
