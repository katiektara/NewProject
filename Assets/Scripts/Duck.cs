using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Runtime.InteropServices;

public class Duck : MonoBehaviour {
    [SerializeField]
    NavMeshAgent agent;

    [SerializeField]
    Transform target;

    [DllImport("Unity")]
    private static extern int get5();
    void Start () {
        agent.SetDestination(target.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
