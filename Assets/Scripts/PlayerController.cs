using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Animator anim;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            anim.SetBool("walk", true);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            anim.SetBool("walk", true);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            anim.SetBool("walk", true);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            anim.SetBool("walk", true);

        if (Input.GetKeyUp(KeyCode.UpArrow))
            anim.SetBool("walk", false);
        if (Input.GetKeyUp(KeyCode.DownArrow))
            anim.SetBool("walk", false);
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            anim.SetBool("walk", false);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            anim.SetBool("walk", false);

        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetBool("jump", true);
        if (Input.GetKeyUp(KeyCode.Space))
            anim.SetBool("jump", false);
    }
}
