using UnityEngine;
using System.Collections;

public class comprar_tienda : MonoBehaviour {


    private int clicks;

    // Use this for initialization
    void Start()
    {
        clicks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (clicks > 1)
        {
            OnMouseUp();
        }
    }

    void OnMouseUp()
    {
        sumar_Moneda.moneda= sumar_Moneda.moneda - 1;
    }
}
