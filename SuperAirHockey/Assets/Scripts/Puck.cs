using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puck : MonoBehaviour
{
    private Rigidbody rigidbody;

    private List<Transform> puckLastPos;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (CompareTag("Player"))
        {
            //rigidbody.AddForce();
        }
    }
}
