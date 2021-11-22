using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Vector3 Force = new Vector3(0, 0,2f);
    private Rigidbody _rigidbody;
    public int _collisionObjectNumber;

    void Awake()
    {
        if (_collisionObjectNumber == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_collisionObjectNumber == 0)
        {
            _rigidbody.AddForce(Force, ForceMode.Force);
        }
        else
        {
            _rigidbody.AddForce(-Force, ForceMode.Force);
        }
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
