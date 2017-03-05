using UnityEngine;
using System.Collections;

public class animateCharacter : MonoBehaviour {
	public Animation animate;
	// Use this for initialization
	void Start () {
		animate.GetComponent<Animation> ();
		animate.Play("Run");
		Debug.Log ("here");
	}
	
	// Update is called once per frame
	void Update () {
		animate.Play("Run");
		Debug.Log ("here2");
	}
}
