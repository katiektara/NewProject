﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour {

    Animator anim;


	void Start () {
        anim = GetComponent<Animator>();
	}
	

	void Update () {
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move);
	}
}
