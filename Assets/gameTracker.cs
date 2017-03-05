using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameTracker : MonoBehaviour {
	private TimeManager timeManager;
	private Spawner spawner;
	public GameObject floor;
	public GameObject player;
	public GameObject obstacle;
	public Text continueText;
	private float blinkTime = 0f;
	private bool blink; 

	void Awake(){
		floor = GameObject.Find ("Floor");
		spawner = GameObject.Find ("Spawner").GetComponent<Spawner> ();
		timeManager = GetComponent<TimeManager> ();
		obstacle = GameObject.Find ("Obstacles");

	}

	// Use this for initialization
	void Start () {
		var floorHeight = floor.transform.localScale.y;
		var pos = floor.transform.position;
		pos.x = 0;

		pos.y= -((Screen.height / pixelCamera.pizelsToUnit) /2) + (floorHeight /2);
		floor.transform.position = pos;

		continueText.text = "Don't get stuck, good luck!";
		
	}
	
	// Update is called once per frame
	void Update () {
		blinkTime++;

		if (blinkTime % 40 == 0) {
			blink = !blink;
		}

		continueText.canvasRenderer.SetAlpha (blink ? 0 : 1);
	}

	void OnCollisionEnter2D(Collision2D obstacle) { 
		Destroy (player);
	}

	void OnPlayerKilled(){
		spawner.active = false;

		var playerDestroyScript = player.GetComponent<DestroyOffScreen> ();
		playerDestroyScript.DestroyCallback -= OnPlayerKilled;

		player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		timeManager.ManipulateTime (0, 5.5f);
	}


}
