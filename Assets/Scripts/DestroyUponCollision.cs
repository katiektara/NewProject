using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUponCollision : MonoBehaviour {

    public Transform Spawnpoint;
    public bool alive = true;

   
    void OnTriggerEnter(Collider other)
    {

        Destroy(this.gameObject);
        Instantiate(this.gameObject, Spawnpoint.transform.position, Quaternion.identity);
        alive = false;
    }

    
   
}
