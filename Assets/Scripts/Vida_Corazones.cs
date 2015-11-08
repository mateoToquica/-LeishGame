using UnityEngine;
using System.Collections;

public class Vida_Corazones : MonoBehaviour
{

    public GUITexture image;
    public Texture2D Image_01;
    public Texture2D Image_02;
    public Texture2D Image_03;
    public Texture2D Image_04;

    public static int vida = 3; // variable vida

    void Update()
    {
        if (vida == 3)
        {
            image.texture = Image_01;
        }
        if (vida == 2)
        {
            image.texture = Image_02;
        }
        if (vida == 1)
        {
            image.texture = Image_03;
        }
        if (vida == 0)
        {
            image.texture = Image_04;
        }

    }
}