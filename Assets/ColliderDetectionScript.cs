using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetectionScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.name);
    }
}
