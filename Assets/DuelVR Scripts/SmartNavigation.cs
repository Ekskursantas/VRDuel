using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SmartNavigation : MonoBehaviour {
	private Transform target;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		target = GameObject.FindWithTag ("goal").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
	}
}
