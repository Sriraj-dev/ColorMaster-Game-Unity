using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class Moveup : MonoBehaviour
{

    public Rigidbody2D rb;
    float velocity ;
    float time;
    float current_time;
    public static int Score;
    int flag;
    public GameObject anim;
    public AudioClip pop;
    public AudioSource source;
    void Start()
    {
 
        velocity = 2;
        time = Time.deltaTime;
        current_time = time;
        source.clip = pop;
       
    }

    void Update()
    {
        current_time += Time.deltaTime;
        if(current_time <= 0.8f)
        rb.velocity = new Vector2(0f,velocity);
        else if(current_time >0.8f && current_time<=1.4)
        {
           rb.velocity = new Vector2(0f,0f);
        }
        else if(current_time >1.4f && current_time<=2f)
        {
            rb.velocity = new Vector2(0f,-velocity);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Add()
    {
        Score+=1;
    }
    void Substract()
    {
        Score-=1;
    }
    void abc()
    {
        Debug.LogError("invoke ran");
        
        SceneManager.LoadScene("rat_level_completed");

    }
    IEnumerator waiter(float t)
    {
        yield return new WaitForSeconds(t);
    }
        void OnMouseDown()
    {

        if (gameObject.tag == "Red")
        {
             //load a lost scene;
             source.Play();
             Instantiate(anim,transform.position + new Vector3 (0f,0.4f,0f),Quaternion.identity);
            StartCoroutine(waiter(10));
            SceneManager.LoadScene("rat_level_completed");

            Debug.Log("You lost");
            new_scene.move_to_next_scene = true;

            //Invoke("abc", 1);
          //  GameManager.Whack_a_mole_lost(Score);
        }
        else if(flag==0)
        {
            
            //Instantiate
            source.Play();
            Instantiate(anim,transform.position + new Vector3 (0f,0.4f,0f),Quaternion.identity);
            
        flag = 1;
        Debug.Log("yeah!!it worked");
        Debug.Log(gameObject.tag + "is being hit");
        
        int i = Showcolor.i;
         
         if(i==0)
         {
             if(gameObject.tag == "cyan")
             {
                 Debug.Log("Correct Hit!!");
                 Debug.Log("Add1");
                 Add();
             }
             else
             {
                 Debug.Log("Wrong Hit!!");
                 Debug.Log("Subs1");
                // Score-=1;
                Substract();
             }
         }
         else if(i==1)
         {
            if(gameObject.tag == "magenta")
             {
                 Debug.Log("Add2");
                 Debug.Log("Correct Hit!!");
                // Score+=1;
                Add();
             }
            else
             {
                 Debug.Log("Wrong Hit!!");
                  Debug.Log("Subs2");
                 //Score -=1;
                 Substract();
             }

         }
         else if(i==2)
         {
            if(gameObject.tag == "purple")
             {
                 Debug.Log("Correct Hit!!");
                  Debug.Log("add3");
                 //Score +=1;
                 Add();
             }
            else
             {
                 Debug.Log("Wrong Hit!!");
                  Debug.Log("Subs3");
                 //Score-=1;
                 Substract();

             }

         }
         else if(i==3)
         {
            if(gameObject.tag == "yellow")
             {
                 Debug.Log("Correct Hit!!");
                  Debug.Log("add4");
                 //Score+=1;
                 Add();
             }
            else
             {
                 Debug.Log("Wrong Hit!!");
                  Debug.Log("Subs4");
                // Score-=1;
                Substract();
             }
         }
        }

    }
}
