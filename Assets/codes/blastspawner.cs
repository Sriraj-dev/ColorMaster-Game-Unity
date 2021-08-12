using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blastspawner : MonoBehaviour
{
    public ParticleSystem blast;
    public Color[] colors;
    float time;
    float current_time;
    public float timegap;
    int flag=0;
    void Start()
    {
        time = Time.deltaTime;
        current_time = time;
         Instantiate(blast,transform.position,Quaternion.identity);
    }

    
    void Update()
    {
        current_time += Time.deltaTime;

        if(current_time >= time+timegap)
        {
            if(flag==0)
            {
                flag=1;
                int r= Random.Range(0,4);
                blast.startColor =  colors[r];
                 Instantiate(blast,transform.position,Quaternion.identity);
            }
            time = current_time;
        }
        else
        {
            //Invoke("Kill",2f);
            flag = 0;
        }
    }
    void Kill()
    {
        Destroy(blast);
    }
}
