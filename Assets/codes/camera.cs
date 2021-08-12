using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float velocity;
    bool death;
    float speed;
    float current_time;
    float time;
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");   
        death = false;
        speed=1;
        time  = Time.deltaTime;
        current_time = time;
    }

    // Update is called once per frame
    void Update()
    {
        current_time+=Time.deltaTime;
        if(current_time >= time+20)
        {
            speed += 0.3f;
            time = current_time;
        }
        if(death)
        {
            velocity = 0f;
            Debug.Log("Stopped");
        }
        else
        {
            if(Input.touchCount>0 || Input.GetKey(KeyCode.UpArrow))
            {
                  velocity = speed+1;
            }
            else
            {
                   velocity = speed;
            }
              // transform.position = player.transform.position + new Vector3(0, 1.2f, -10);

        }
        
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0f,velocity);
    }

    public void Check()
    {
        death = true;
    }
}
