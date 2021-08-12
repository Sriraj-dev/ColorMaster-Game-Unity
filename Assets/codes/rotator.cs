using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{ 
    public float rotation_speed;
    
    void Update()
    {
        transform.Rotate(0, 0, rotation_speed * Time.deltaTime);
        
    }
}
