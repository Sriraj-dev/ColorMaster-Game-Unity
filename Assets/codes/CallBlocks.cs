using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBlocks : MonoBehaviour
{
    
    public Transform[] pos;
    public GameObject[] blocks;
    float time;
     float current_time;
     int flag;
    void Start()
    {
        time = Time.deltaTime;
        current_time = time;
        flag=0;
    }

    // Update is called once per frame
    void Update()
    {
        current_time += Time.deltaTime;
        
        if(current_time >=time+4f)
        {   
            if(flag==0)
            {
                  Spawn();
                  flag=1;
            }    
            time = current_time;
        }
        else
        {
                flag=0;
        }
        
            
        
        
    }

    void Spawn()
    {
                int r1 = Random.Range(1,5);
                for(int i=0;i<r1;i++)
                {
                 int r2 = Random.Range(0,4);
                 int r3 = Random.Range(0,4);
                 Instantiate(blocks[r2],pos[r3].position,Quaternion.identity);
                  Debug.Log("Im spawing");
                }
    }
}
