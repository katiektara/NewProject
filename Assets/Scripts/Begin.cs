using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour {

    
    public GameObject WhatToSpawn;

    void Start()
    {
        Instantiate(WhatToSpawn.gameObject, gameObject.transform.position, Quaternion.identity);
    }

}
