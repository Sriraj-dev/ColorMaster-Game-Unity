using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftandright1 : MonoBehaviour
{
     public Rigidbody2D rb;
    void Start()
    {
         rb.velocity = new Vector2(-1f,0f);
    }
    void Update()
    {
       

        
        if(transform.position.x <=-1.8f)
        {
            Debug.Log("MovingForward");
            rb.velocity = new Vector2(2f,1f);
        }
        if(transform.position.x >=2f)
        {
            rb.velocity = new Vector2(-2f,1f);
        }
        
    }
}
