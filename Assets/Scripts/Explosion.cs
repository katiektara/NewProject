using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public Transform explosion;

    private void OnTriggerEnter(Collider hit)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        if (hit.gameObject.tag == "Player")
        {
            
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
       
    }
}
