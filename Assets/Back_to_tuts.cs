using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_to_tuts : MonoBehaviour
{
    public SpriteRenderer se;
    public Sprite[] s;
    int flag;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    public void changesprite()
    {
        if(flag==0)
        { se.sprite = s[1];flag=1;}
        else if(flag==1)
        { SceneManager.LoadScene("hello");}
        
    }
    void flaginc()
    {flag++;}
}
