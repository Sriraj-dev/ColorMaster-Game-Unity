using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeMove : MonoBehaviour
{ }
    /*
    public float speed = 200.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    public Joystick joystick;
    float hmove = 0;
    float vmove = 0;
    private Rigidbody2D rb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("blue");
        rb = gameObject.GetComponent<Rigidbody2D>();
        Debug.Log("running");
        Debug.Log(joystick.Horizontal);
        // rb.velocity = new Vector2(3, 9);
    }
    void Update()
    {
        Debug.Log(joystick.Horizontal);
        rb.velocity = new Vector2(joystick.Horizontal, joystick.Vertical);
        pointA.x = joystick.Horizontal;
        pointA.y = joystick.Vertical;
        player.transform.Translate(pointA * speed * Time.deltaTime);
    }
}*/
/* void Start()
 {
     j = new Vector3(transform.position.x - 6.629974f, transform.position.y - 2.720001f, 0);
     circle.transform.position = new Vector3(transform.position.x - 6.629974f, transform.position.y - 2.720001f, 0);
     outerCircle.transform.position = j;
     circle.GetComponent<SpriteRenderer>().enabled = true;
     outerCircle.GetComponent<SpriteRenderer>().enabled = true;
 }
 // Update is called once per frame
 void Update()
 {
     j = new Vector3(transform.position.x - 6.629974f, transform.position.y - 2.720001f, 0);
     circle.transform.position = new Vector3(transform.position.x - 6.629974f, transform.position.y - 2.720001f, 0);
     outerCircle.transform.position = j;





     if (Input.GetMouseButtonDown(0))
     {
         pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

         //circle.transform.position = pointA * -1;
         //outerCircle.transform.position = pointA * 1;
         circle.GetComponent<SpriteRenderer>().enabled = true;
         outerCircle.GetComponent<SpriteRenderer>().enabled = true;
     }
     if (Input.GetMouseButton(0))
     {
         touchStart = true;
         pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
     }
     else
     {
         touchStart = false;
     }

 }
 private void FixedUpdate()
 {
     if (touchStart)
     {
         Vector2 offset = pointB - pointA;
         Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
         moveCharacter(direction * 1);

         //circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * 1;
         circle.transform.position = new Vector2(j.x+direction.x,j.y+ direction.y) * 1;
     }
     else
     {
         circle.GetComponent<SpriteRenderer>().enabled = true;
         outerCircle.GetComponent<SpriteRenderer>().enabled = true;
     }

 }
 void moveCharacter(Vector2 direction)
 {
     player.Translate(direction * speed * Time.deltaTime);
 }*/
