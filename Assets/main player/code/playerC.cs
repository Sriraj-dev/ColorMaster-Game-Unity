using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerC : MonoBehaviour
{
    public static bool dead;
    static TrailRenderer t;
    static Rigidbody2D rb;
    public static float dirX;
    public static float dirY;
    public static float vel;
    int count;
    public float moveSpeed = 20f;
    static SpriteRenderer sr;
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
    private Vector2 startTouchPosition, endTouchPosition;
    public float spawnrate = 1f;
    private float nexttimetospawn = 2f;
    Camera maincamera;
    Vector2 d;

    public AudioSource thunder;
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        maincamera= GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        this.gameObject.tag = "Player";
        t = gameObject.GetComponent<TrailRenderer>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        randomcolor();
        vel = 1f;
        rb = gameObject.GetComponent<Rigidbody2D>();
        count = 0;
        score_saver.level_name = "c";
        score_saver.level_number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (dirY < 0) { dirY = 1; }
        random_astroid_color.change_astroid_color = false;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2f, 2f), transform.position.y);
        current_color = sr.color;
        current_gradient = t.colorGradient;
      //dirX = Input.acceleration.x * moveSpeed;
       // dirX = Input.GetAxis("Horizontal");
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            endTouchPosition = Input.GetTouch(0).position;
            //d = startTouchPosition - endTouchPosition;
            dirY = (endTouchPosition.y - startTouchPosition.y) * 0.02f;
            dirX = (endTouchPosition.x - startTouchPosition.x) * 0.04f;

            /* if ((endTouchPosition.x < startTouchPosition.x))
             {
                 dirY = (endTouchPosition.y-startTouchPosition.y)*0.02f;
                 dirX = -6f;
             }

             if ((endTouchPosition.x > startTouchPosition.x))
             {
                 dirY = (endTouchPosition.y - startTouchPosition.y)*0.02f;


                 dirX = 6f;
             }*/
            
        }
        //else { if (dirX != 0) { dirY = 0; dirX -= 1f; } }
        if (Time.time >= nexttimetospawn)
        { 
            random_astroid_color.change_astroid_color = true;
            random_background();
            thunder.Play();

            Invoke("randomcolor",0.2f);
            nexttimetospawn = Time.time + 1f / spawnrate; 
            count++;
        }
        if(count==3)
        {
            count = 0;
            vel+=0.2f;
        }
    }
 
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, vel+dirY);
        if (dead == true)
        {
            dead = false;
            Destroy(gameObject);
            
        }
    }
    public void random_background()
    {
        int i;
        i = Random.Range(0, 4);
        switch (i)
        {
         

            case 0:
                maincamera.backgroundColor = yellow;

                break;
            case 1:
                maincamera.backgroundColor = magenta;


                break;
            case 2:
                maincamera.backgroundColor = cyan;


                break;
            case 3:
                maincamera.backgroundColor = purple;


                break;
        }
    }
    public void randomcolor()
    {
            maincamera.backgroundColor = Color.black;
        int i;
        i = Random.Range(0, 4);
        switch (i)
        {
            case 0:
                t.colorGradient = yellow_;
                sr.color = yellow;
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
