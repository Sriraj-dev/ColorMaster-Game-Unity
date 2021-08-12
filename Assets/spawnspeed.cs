using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnspeed : MonoBehaviour
{
    // Start is called before the first frame update
    float velocity;
public Rigidbody2D rb;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        velocity = playerC.vel+playerC.dirY + 1f;        
    }
    void FixedUpdate()
    {
     rb.velocity = new Vector2(0,velocity);
    }
}