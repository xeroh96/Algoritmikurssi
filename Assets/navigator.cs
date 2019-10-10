using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class navigator : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
        GetComponent<NavMeshAgent>().destination = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
