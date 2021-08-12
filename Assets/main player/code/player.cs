using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    static TrailRenderer t;
  static   Rigidbody2D rb;
    float dirX;
   public  float moveSpeed = 20f;
   static  SpriteRenderer sr;
    public Color yellow;
    public Color cyan;
    public Color magenta;
    public Color purple;
    public Gradient yellow_;
    public Gradient cyan_;
    public Gradient purple_;
    public Gradient magenta_;
    static public Color current_color;
    static public Gradient current_gradient;
    float velocity;
    float speed;
    float current_time;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.GetComponent<TrailRenderer>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        randomcolor();
        rb = gameObject.GetComponent<Rigidbody2D>();
        speed=1;
        time = Time.deltaTime;
        current_time = time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2f, 2f),transform.position.y);
        current_color = sr.color;
        current_gradient = t.colorGradient;
        dirX = Input.acceleration.x * moveSpeed;
        //dirX = Input.GetAxis("Horizontal");
        
        current_time += Time.deltaTime;
        if(current_time >= time+20)
        {
            
            speed+=0.3f;
            moveSpeed += 0.3f;
            time = current_time;
            Debug.Log("Speed is Increased to "+ speed);
        }
        if(Input.touchCount > 0 || Input.GetKey(KeyCode.UpArrow))
        {
            velocity = speed +1;
        }
        else
        {
            velocity = speed;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, velocity);
        bool check = collision.special;
        if(check)
        {
            randomcolor();
        }
    }

  public  void randomcolor()
    {
        Debug.Log("random color ran");
        int i;
        i = Random.Range(0, 4);
        switch (i) {
            case 0:
                t.colorGradient = yellow_;
                sr.color= yellow;
                this.gameObject.tag = "yellow";
                break;
            case 1:
                t.colorGradient = magenta_;
                sr.color = magenta;
                this.gameObject.tag = "magenta";

                break;
            case 2:
                t.colorGradient = cyan_;
                sr.color = cyan;
                this.gameObject.tag = "cyan";

                break;
            case 3:
                t.colorGradient = purple_;
                sr.color = purple;
                this.gameObject.tag = "purple";

                break;
        }
    }
public void change_to_yellow()
    {
        t.colorGradient = yellow_;
        sr.color = yellow;
        this.gameObject.tag = "yellow";

        Debug.Log("color is" + sr.color);
    }
public void change_to_cyan()
    {
        t.colorGradient = cyan_;
        sr.color = cyan;
        this.gameObject.tag = "cyan";

        Debug.Log("color is" + sr.color);
    }
public void change_to_purple()
    {
        t.colorGradient = purple_;
        sr.color = purple;
        this.gameObject.tag = "purple";

        Debug.Log("color is" + sr.color);
    }
public void change_to_magenta()
    {
        t.colorGradient = magenta_;
        sr.color = magenta;
        this.gameObject.tag = "magenta";

        Debug.Log("color is" + sr.color);
    }
}
