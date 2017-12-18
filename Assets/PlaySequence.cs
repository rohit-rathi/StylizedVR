using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySequence : MonoBehaviour {
	public GameObject left;
	public GameObject right;
	Renderer leftRend;
	Renderer rightRend;

	int count = 1;
	int a;
	float time = 0;

	// Use this for initialization
	void Start () {
		leftRend = left.GetComponent<Renderer> ();
		rightRend = right.GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		//if (count < 51) {
			time += Time.deltaTime;
			if (time > 0.05f) {
				time = 0;
			string leftString = "frame_" + count.ToString ("0000");
			string rightString = "frame_" + count.ToString ("0000") + "R";
				Debug.Log (leftString);
				Debug.Log (rightString);
				leftRend.material.mainTexture = Resources.Load (leftString) as Texture;
				rightRend.material.mainTexture = Resources.Load (rightString) as Texture;
			if (count < 50) {
				//count++;
			} else {
				count = 1;
			}
		}
	}
}
