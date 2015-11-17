using UnityEngine;
using System.Collections;

public class sumar_Moneda : MonoBehaviour {

    public GUITexture image;
    public Texture2D Image_01;
    public Texture2D Image_02;
    public Texture2D Image_03;
    public Texture2D Image_04;

    public static int moneda = 0; // variable vida

    void Update()
    {

        if (moneda >= 3)
        {
            moneda = 3;
        }
        if (moneda == 3)
        {
            image.texture = Image_01;
        }
        if (moneda == 2)
        {
            image.texture = Image_02;
        }
        if (moneda == 1)
        {
            image.texture = Image_03;
        }
        if (moneda == 0)
        {
            image.texture = Image_04;
        }

    }
}
