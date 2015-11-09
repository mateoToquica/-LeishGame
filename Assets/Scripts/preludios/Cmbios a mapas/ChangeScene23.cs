using UnityEngine;
using System.Collections;

public class ChangeScene23 : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			Application.LoadLevel("Preludio23");
		}
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
