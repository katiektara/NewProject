using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
     
    public Transform explosion;
    public bool alive = false;


  

    private void OnTriggerEnter(Collider hit)
    {
      
        Instantiate(explosion, transform.position, transform.rotation);
        if (hit.gameObject.tag == "Player")
        {
            Instantiate(explosion, this.gameObject.transform.position, Quaternion.identity);         
            Destroy(this.gameObject);
            Instantiate(gameObject);
            alive = true;
            
        }

    }
   
}
