using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeJointScript : MonoBehaviour
{

    public Vector3 Force = new Vector3(0, 20, 0 );
    private Rigidbody _rigidbody;
    public int _hingeJointObjectNumber;

    void Awake()
    {
        if (_hingeJointObjectNumber == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

       _rigidbody.AddForce(Force, ForceMode.Acceleration);


    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
