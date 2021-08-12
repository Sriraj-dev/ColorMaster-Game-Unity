using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleDestroy : MonoBehaviour
{
   
  // public collision script;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Collider)
    {
        //bool check = script.power();
        if(Collider.tag == gameObject.tag)
        {
            Destroy(gameObject);
        }

    }
}
