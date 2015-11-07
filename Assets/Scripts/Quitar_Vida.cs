using UnityEngine;
using System.Collections;

public class Quitar_Vida : MonoBehaviour {


    // OnTriggerEnter cuando el se entra al objeto cambia el valor de  VIDA_Corazones.vida en -1 simulando la perda de vida
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemigo"))
        {
            Vida_Corazones.vida = Vida_Corazones.vida - 1;
            if (Vida_Corazones.vida <= 0)
            {//si la vida es menor o igual a 0
             //aca ponen lo que quieran por ejemplo una animacion de morir o nc, un texto que diga estas muerto etc
            }
        }
        if (other.gameObject.CompareTag("moneda"))
        {
            Vida_Corazones.vida = Vida_Corazones.vida + 1;
			Time.timeScale=0;

        }


    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
