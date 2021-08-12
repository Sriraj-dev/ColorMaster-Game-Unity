using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score_animation : MonoBehaviour
{
    Transform t;
    SpriteRenderer sr;
    float scale;
    float starttime;
  
    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.GetComponent<Transform>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        t.localScale = new Vector3(0.001f,0.001f,1f);
        scale = 0.001f;
        starttime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        scale += 0.001f;
    
        if (scale < 0.02)
        {
            t.localScale = new Vector3(scale, scale, 1f);
        }
        if (Time.time-starttime >2f)
        {
            if (gameObject.tag == "gameover")
            {
                SceneManager.LoadScene("gamewon");
            }
            Destroy(this.gameObject);
        }

    }
}
