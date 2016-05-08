using UnityEngine;
using System.Collections;

public class MushroomSpawner : MonoBehaviour {

	public GameObject mushroomPrefab;
	public int maxMushroomCount;

	private GameObject[] mushroomArray;
	private Player player;
	private PhysicsRayCaster physicsRayCaster;
	private Mushroom mushroom;
	private int mushroomCount;
	private int mushroomArrayIndex = 0;
	private SceneControl sceneControl;

	// Use this for initialization
	void Start () {
		mushroomArray = new GameObject[maxMushroomCount];
		sceneControl = GameObject.FindObjectOfType<SceneControl> ();

		Cardboard.SDK.OnTrigger += PullTrigger;


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InstantiateMushroomLimit(){
		

		player = GameObject.FindObjectOfType<Player> ();
		physicsRayCaster = GameObject.FindObjectOfType<PhysicsRayCaster> ();

		if(mushroomArrayIndex < maxMushroomCount -1){
			InstantiateMushroom (mushroomArrayIndex);
			mushroomArrayIndex++;

		} else{
			Destroy (mushroomArray [0]);
			for (int i = 1; i < maxMushroomCount; i++){
				mushroomArray [i-1] = mushroomArray [i];
			}
			InstantiateMushroom (maxMushroomCount -1);
			mushroomArrayIndex++;

		}

	}

	void InstantiateMushroom(int indexNumber){
		GameObject mushroomObject = Instantiate (mushroomPrefab);
		Vector3 placePosition = Vector3.ProjectOnPlane (physicsRayCaster.RayHitPoint (), Vector3.up);
		mushroomObject.transform.name = "mushroom" + mushroomArrayIndex;
		mushroomObject.transform.position = placePosition;
		mushroomObject.transform.parent = transform;
		mushroomArray [indexNumber] = mushroomObject;

	}




	void PullTrigger () {
		if(!sceneControl.isGameOver) {
			InstantiateMushroomLimit ();
		}

	}

	bool isMushroomFull(){
		mushroom = GameObject.FindObjectOfType<Mushroom> ();
		mushroomCount = mushroom.MushroomCounter ();
		if(mushroomCount > maxMushroomCount - 1){
			return true;
		} else{
			return false;
		}
	}


}
