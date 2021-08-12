using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class astroid_tutorial : MonoBehaviour
{
    int first_timea;
    int first_timer;
    public Sprite a1;
    public Sprite r1;
    public Sprite a2;
    public Sprite r2;
    public Sprite r3;
    public SpriteRenderer sr;
    public bool rat_or_not=false;

    // Start is called before the first frame update
    void Start()
    {
        first_timea=PlayerPrefs.GetInt("first_timeastroid");
        first_timer=PlayerPrefs.GetInt("first_timerat");
        if(rat_or_not==false  )//&& first_timea == 0)
        {
            PlayerPrefs.SetInt("first_timeastroid", 1);
            Time.timeScale =0;
        }
        if (rat_or_not == true && first_timer == 0)
        {
            PlayerPrefs.SetInt("first_timerat", 1);
            Time.timeScale = 0;

        }

    }
    void A1()
    {
        sr.sprite = a1;
        Invoke("A2", 1);
    }
    void A2()
    {
        sr.sprite = a2;

        Invoke("Done", 1);
    }
    void R3()
    {
        sr.sprite = r3;

        Invoke("Done", 1);

    }
    void Done()
    {
      
        Time.timeScale = 1;

    }


}
