using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{
    
    public Rigidbody2D rb;
    void Start()
    {
        int r1 = Random.Range(-1,2);
        int r2 = Random.Range(-1,2);
        rb.velocity = new Vector2(r1,r2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
