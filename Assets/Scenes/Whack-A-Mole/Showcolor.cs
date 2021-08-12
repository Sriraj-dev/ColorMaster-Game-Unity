using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Showcolor : MonoBehaviour
{
    
    public Color[] colors;
    public Image color_;
    public static int i;
    float time;
    float current_time;
    int flag;
    void Start()
    {
        randomcolor();
        time = Time.deltaTime;
        current_time = time;
    }

    // Update is called once per frame
    void Update()
    {
         current_time +=Time.deltaTime;
         if(current_time >= time+8f)
         {
            color_.GetComponent<Image>().color = colors[4];
            if(flag==0)
            {
                randomcolor();
                flag=1;
            }
            time = current_time;
         }       
         else
         {
             flag=0;
         }
    }

    public  void randomcolor()
    {
        Debug.Log("random color initiated");
        
        i = Random.Range(0, 4);
        switch (i) {
            case 0:
                //cyan
                Debug.Log("cyan");
                color_.GetComponent<Image>().color = colors[0];
                break;
            case 1:
                //magenta
                Debug.Log("magenta");
                 color_.GetComponent<Image>().color = colors[1];
                break;
            case 2:
                //purple
                Debug.Log("purple");
                  color_.GetComponent<Image>().color = colors[2];
                break;
            case 3:
                //yellow
                Debug.Log("yellow");
                 color_.GetComponent<Image>().color = colors[3];
              
                break;
        }
    }
}
