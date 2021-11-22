using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject bomb;
    public float _explosionPower = 15.0f;
    public float _explosionRadius = 5.0f;
    public float _explosionUpForce = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (bomb == enabled)
        {
            Invoke("Detonate", 2);
            if (bomb != null)
            {
                Destroy(bomb, 2.05f);
            }

        }
    }

    void Detonate()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, _explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(_explosionPower, explosionPosition, _explosionRadius, _explosionUpForce, ForceMode.Impulse);
            }
        }
    }


}
