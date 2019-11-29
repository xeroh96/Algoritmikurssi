using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SimpleSwap : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    private bool walkedIn = false;
     
     void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            walkedIn = !walkedIn;
        }
    }

     void Update()
    {
        if(walkedIn == true)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        if(walkedIn == false)
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
        
    }
} 
