using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speicalcode : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if(Collider.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
