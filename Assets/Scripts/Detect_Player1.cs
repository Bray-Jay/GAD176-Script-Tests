using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Detect_Player1 : MonoBehaviour
{
    public Rigidbody SPIKES;
    public Transform thingHit;
    public float speed = 1.0f;
    public Transform BOX;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello there");

        if (collision.transform.tag == "GUY");
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
        transform.position = new Vector3(0.0f, 1.0f, 0.0f);
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, BOX.position, step);

        if (Vector3.Distance(transform.position, BOX.position) < 0.001f)
        {
            BOX.position *= -1.0f;
        }
        else 
        { 
        }
    }
}