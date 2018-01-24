using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    private void Update()
    {
        if (Input.GetKeyDown  (KeyCode.H))
#pragma warning disable CS0618 // Тип или член устарел
            Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Тип или член устарел
    }

}
