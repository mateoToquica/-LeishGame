using UnityEngine;
using System.Collections;

public class Preludio34 : MonoBehaviour {

	float tiempo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		if (tiempo >= 2.2f) {
			print ("entro");
			Application.LoadLevel ("JuegoMap4");
		} else {
			print("no entro");
		}
	}
}
