﻿using UnityEngine;
using System.Collections;

public class LookAtScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Camera.main.transform.position);
	}
}
