using UnityEngine;
using System.Collections;

public class Quitar_vida5 : MonoBehaviour {


	 void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemigo"))
        {
            Vida_Corazones.vida = Vida_Corazones.vida - 1;
            GameObject.FindGameObjectWithTag("pj").transform.position = new Vector4(22, 2, 0);
            if (Vida_Corazones.vida <= 0)
            {//si la vida es menor o igual a 0
				Application.LoadLevel("Final");
				Vida_Corazones.vida = 3;
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
