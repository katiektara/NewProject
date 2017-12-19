using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject prefab;
    public float Time = 3f;

    void Start()
    {
        Invoke("Spawn", Time);
    }


    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
