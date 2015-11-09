using UnityEngine;
using System.Collections;

public class Quitar_Vida2 : MonoBehaviour {

	void reset()
	{
		Application.LoadLevel("Final");
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemigo"))
        {
            Vida_Corazones.vida = Vida_Corazones.vida - 1;
            GameObject.FindGameObjectWithTag("pj").transform.position = new Vector4(13, 3, -15);
            if (Vida_Corazones.vida <= 0)
            {//si la vida es menor o igual a 0
				Vida_Corazones.vida = 3;
				reset ();
	
             //aca ponen lo que quieran por ejemplo una animacion de morir o nc, un texto que diga estas muerto etc
            }
        }
        if (other.gameObject.CompareTag("moneda"))
        {
            Vida_Corazones.vida = Vida_Corazones.vida + 1;
            //	Time.timeScale=0;
           
        }


    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
