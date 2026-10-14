using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Detect_Player : MonoBehaviour
{
    public Rigidbody SPIKES;
    public Transform thingHit;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello there");

        if (collision.transform.tag == "GUY") ;
        {
            thingHit = collision.transform;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Byee");
        thingHit = null;
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Staying On");
    }

    void Start()
    {
        SPIKES = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (OnCollisionEnter)
            if (thingHit != null)
        {
            Debug.Log("I'm no longer hitting it.");
        }
    }
}