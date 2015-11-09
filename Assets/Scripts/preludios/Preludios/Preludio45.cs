using UnityEngine;
using System.Collections;

public class Preludio45 : MonoBehaviour {
	float tiempo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		if (tiempo >= 2.2f) {
			print ("entro");
			Application.LoadLevel ("JuegoMap5");
		} else {
			print("no entro");
		}
	}
}
