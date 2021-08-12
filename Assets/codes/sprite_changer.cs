using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_changer : MonoBehaviour
{
    static public  int i;
    public string[] tags;
    public  Sprite[] sprites;

    SpriteRenderer sr;
    GameObject t;
    GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        g = this.gameObject;
        t = GameObject.FindGameObjectWithTag("Player");
        sr = gameObject.GetComponent<SpriteRenderer>();
        int i = Random.Range(0, sprites.Length);
        sr.sprite = sprites[i];
        this.gameObject.tag = tags[i];

    }

    // Update is called once per frame
    void FixedUpdate()
    {if (random_astroid_color.change_astroid_color == true)
        {
            Debug.Log("abc");
             i = Random.Range(0, sprites.Length);
            sr.sprite = sprites[i];
            this.gameObject.tag = tags[i];
            Debug.Log("color is" + i );

        }

    }
     void Update()
    {
        if (transform.position.y + 5 < t.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
