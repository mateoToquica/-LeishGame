﻿using UnityEngine;
using System.Collections;

public class Preludio23 : MonoBehaviour {

	float tiempo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		if (tiempo >= 4.2f) {
			print ("entro");
			Application.LoadLevel ("JuegoMap3");
		} else {
			print("no entro");
		}
	}
}
