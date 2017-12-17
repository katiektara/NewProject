using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPeng : MonoBehaviour {
    public GameObject Obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "Player")
        {
            Obj.GetComponent<Animator>().SetTrigger("Enter");
        }
    }
}
