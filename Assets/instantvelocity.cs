using UnityEngine;
using System.Collections;

public class instantvelocity : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;

	private Rigidbody2D body2d;

	// Use this for initialization
	private void Awake() {
		body2d = GetComponent<Rigidbody2D>();
		Debug.Log ("here");
	}

	// Update is called once per frame
	private void FixedUpdate () {
		Debug.Log (body2d);
		body2d.velocity = velocity;
	}
}
;