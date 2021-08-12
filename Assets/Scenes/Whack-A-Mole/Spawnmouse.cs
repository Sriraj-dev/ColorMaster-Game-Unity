using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmouse : MonoBehaviour
{

    public Transform pos;
    public GameObject[] mouse;
    //public GameObject check;
    public float timegap;
    float time;
    float current_time;
    void Start()
    {
        time = Time.deltaTime;
        current_time = time;
        
    }

   
    void Update()
    {
        current_time += Time.deltaTime;

        if(current_time >= time + timegap)
        {
            int r = Random.Range(0,mouse.Length); 
            Instantiate(mouse[r],pos.position,Quaternion.identity);
            Debug.Log("Instantiated");
            time = current_time;
        } 
        
    }
}
