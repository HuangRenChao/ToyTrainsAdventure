using UnityEngine;
using System.Collections;

public class PassengerSpawner : MonoBehaviour {

	public GameObject passengerPrefab;
	public Transform[] spawnPositions;
	public float spawnPeriodInSecs;
	public float remainingTimeInSecs;

	private int randomIndex;
	private Timer timer;
	private float spawnPeriodPhase2;
	private float spawnPeriodPhase3;
	// Use this for initialization
	void Start () {
		timer = FindObjectOfType<Timer> ();
		spawnPeriodPhase2 = spawnPeriodInSecs / 2;
		spawnPeriodPhase3 = spawnPeriodInSecs / 4;

		InstantiatePassenger ();
		StartCoroutine (Spawn ());

	}
	
	// Update is called once per frame
	void Update () {
		spawnCurve ();
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

	public void spawnCurve(){
//		spawnPeriodInSecs = Mathf.Pow (timer.timePast, -1f);
		float timePast = timer.timePast;
		float timePoint1 = timer.totalGameTime / 3;
		float timePoint2 = timePoint1 * 2;
		float timePoint3 = timer.totalGameTime;


		if(timePast <= timePoint1){
			spawnPeriodInSecs = spawnPeriodInSecs;
		} else if (timePast <= timePoint2) {
			spawnPeriodInSecs = spawnPeriodPhase2;
		} else if (timePast <= timePoint3) {
			spawnPeriodInSecs = spawnPeriodPhase3;
		}




	}


}
