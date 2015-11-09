using UnityEngine;
using System.Collections;

public class Final : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			Application.LoadLevel("Final");
		}
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
