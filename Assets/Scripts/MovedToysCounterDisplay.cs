using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovedToysCounterDisplay : MonoBehaviour {

	private Text text;
	private TargetGround targetGround;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		targetGround = GameObject.FindObjectOfType<TargetGround> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = targetGround.toysMovedCount.ToString();
	}
}
