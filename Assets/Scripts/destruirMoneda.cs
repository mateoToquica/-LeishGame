using UnityEngine;
using System.Collections;

public class destruirMoneda : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pj"))
        {  
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
