using UnityEngine;
using System.Collections;

public class Mushroom : MonoBehaviour {
	private int mushroomCount = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		

	}



	public int MushroomCounter(){
		mushroomCount = GameObject.FindGameObjectsWithTag ("Mushroom").Length;
		return mushroomCount;
	}
}
