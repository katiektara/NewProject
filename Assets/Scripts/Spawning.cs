using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {
 
    public Transform SpawnPoint;
    public GameObject prefab;
    public bool alive1;
  
    float x;
    float y;
    float z;
    Vector3 pos;


   void Start()
    {
        Instantiate(prefab.gameObject, SpawnPoint.transform.position, Quaternion.identity);
        alive1 = true;
    }

    void Update () {
      /*  GameObject go = GameObject.Find("sheep");
         if   (go == null)   */                        //1 variant
      alive1 = GetComponent<Explosion>().alive;
        if (alive1 == false)                       //2 variant
        {
           
            x = Random.Range(7, 19);
            y = 0;
            z = Random.Range(7, 30);
            pos = new Vector3(x, y, z);
            SpawnPoint.transform.position = pos;
            Instantiate(prefab.gameObject, SpawnPoint.transform.position, Quaternion.identity);
            alive1 = true;
        }
        
    }
}
