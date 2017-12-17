using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUponCollision : MonoBehaviour {

    
    void OnTriggerEnter(Collider other)
    {
        // this.gameObject.SetActive(false);
        //  Debug.Log("Collide");
        Destroy(this.gameObject);

    }
}
