using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public int _explodedObjectNumber;
    void Awake()
    {
        if (_explodedObjectNumber == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (_explodedObjectNumber == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }

        else if (_explodedObjectNumber == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (_explodedObjectNumber == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
