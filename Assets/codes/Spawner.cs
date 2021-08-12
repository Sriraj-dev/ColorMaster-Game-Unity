using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Sets;
    public GameObject[] Specials;
    float time1;
    float time2;
    float current_time;
    float i;
    int count;
    bool death;
    float pos;
    Rigidbody2D rb;
   
    void Start()
    {
        //int r= Random.Range(0,8);
        Debug.Log("Spawing Object");
        Instantiate(Sets[0],transform.position,Quaternion.identity);
        time1 = Time.deltaTime;
        time2 = time1;
        i=1;
        current_time = time1;
        death = false;
        pos = transform.position.x;
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f,3f);
        count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
          current_time += Time.deltaTime;
          if(death)
          {
              
          }
          else
          {
              Debug.Log("current time is - " + current_time);
          Debug.Log("time1 is - " + time1);
          if(current_time >= time1 + 5f)
          {
              if(count <=10*i)
              {
                  Debug.Log("random ");
               int r= Random.Range(0,13);
               Instantiate(Sets[r],transform.position,Quaternion.identity);
               time1 = current_time;
               count+=1;
              }
              else
              {
                int r1 = Random.Range(0,2);
                Instantiate(Specials[r1],transform.position,Quaternion.identity);
                i+=1;
              }
               
          }
        //   if(current_time >= time2 + (25*i))
        //   {
        //       int r= Random.Range(0,2);
        //       Instantiate(Specials[r],transform.position,Quaternion.identity);
        //       time2 = current_time;
        //       i+=1/2;
        //   }

          }      

    }
    public void Check()
    {
        death =true;
    }
}
