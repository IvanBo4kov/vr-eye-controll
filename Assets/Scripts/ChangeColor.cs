using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color colorChange;

    private void OnMouseDown()
    {
        var currentColor = gameObject.GetComponent<MeshRenderer>().material.color;

        if (currentColor != colorChange)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = colorChange;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
