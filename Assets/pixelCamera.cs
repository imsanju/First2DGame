using UnityEngine;
using System.Collections;

public class pixelCamera : MonoBehaviour {

	public static float pizelsToUnit = 1f;
	public static float scale = 1f;

	public Vector2 nativeResolution = new Vector2 (240, 160);
	// Use this for initialization
	void Awake () {
		var camera = GetComponent<Camera> (); 

		if (camera.orthographic) {
			scale = Screen.height / nativeResolution.y;
			pizelsToUnit *= scale;
			camera.orthographicSize = (Screen.height / 2.0f) / pizelsToUnit;
				
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
