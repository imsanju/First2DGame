﻿using UnityEngine;
using System.Collections;

public class repeat : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);

		Renderer renderer = GetComponent<Renderer> ();
		renderer.material.mainTextureOffset = offset;
	}
}
