using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public static int score;
    //public Text text;
    public camera script;
    public Spawner script2;
    public Print script3;
    
    public GameObject objecttouch;
    public GameObject Gamelost;
    public GameObject Special;
    
    public static bool special;
    float start_time;
    float duration;
    float current_time;
    int flag = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        special =false;
        duration = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag==1)
        {
             current_time+=Time.deltaTime;
            Debug.Log("current-time is "+current_time);
            Debug.Log("start_time + duration "+ start_time + duration);
            if(current_time>=start_time + duration)
            {
                Debug.Log("Special stopped");
                special= false;
                flag=0;
            }

        }
    }

    void OnTriggerEnter2D(Collider2D Collider)
    {
          Debug.Log( "Collided with "+Collider.tag);
          Debug.Log("My tag is " + gameObject.tag);

          if(Collider.tag == "Special")
          {
               Instantiate(Special,transform.position,Quaternion.identity);
               special = true;
               start_time = Time.deltaTime;
               current_time = start_time;
               flag=1;
          }
          
            if(gameObject.tag == Collider.tag || special)
            {
                if(Collider.tag == "Red")
                {
                    Instantiate(Gamelost,transform.position,Quaternion.identity);
                    
                     Destroy(gameObject);
                     
                     script.Check();
                     /**********************************/
                      GameManager.gamelost();
                }
                else
                {
                    Instantiate(objecttouch,transform.position,Quaternion.identity);
                Destroy(Collider.gameObject);
                score+=1;
                script3.TakeScore(score);

                }
                
            }
             else
            {
            Instantiate(Gamelost,transform.position,Quaternion.identity);
            Destroy(gameObject);
           
            script.Check();
            /******************************************/
             GameManager.gamelost();
            }

            // current_time+=Time.deltaTime;
            // Debug.Log("current-time is "+current_time);
            // Debug.Log("start_time + duration "+ start_time + duration);
            // if(current_time>=start_time + duration)
            // {
            //     Debug.Log("Special stopped");
            //     special= false;
            // }
    }

    public bool power()
    {
        if(special == true)
        {
            return true;
        }
        else
        return false;
    }
}
