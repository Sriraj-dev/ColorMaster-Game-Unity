using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcolor : MonoBehaviour
{
    
    public Color[] color;
    public Text text;
    // public Color color2;
    // public Color color3;
    // public Color color4;
   public float current_time;
   public float timegap;
    int flag=0;
    public float  start_time;
    void Start()
    {
        current_time = Time.time;     
        flag =0;
         start_time = current_time;
    }

    // Update is called once per frame
    void Update()
    {
         current_time+=Time.time;
         if(current_time >= start_time + timegap && flag==0)
        {
               Debug.Log("ChangeColor");
               int r = Random.Range(0,4);
               text.color = color[r];
               flag = 1;
               start_time = current_time;
        }
        else
        flag = 0;
    }
    void FixedUpdate()
    {
       // int r = Random.Range(0,4);
        //text.color = color[r];
    }
}
