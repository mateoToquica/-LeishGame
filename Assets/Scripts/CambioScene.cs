﻿using UnityEngine;
using System.Collections;

public class CambioScene : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			Application.LoadLevel("juegoMap2");
		}

		
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
