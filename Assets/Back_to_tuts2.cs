using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_to_tuts2 : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer se;
    public Sprite[] s;
    int flag=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void changesprite()
    {
        if(flag==0)
        { se.sprite = s[1];flag=1;}
        else if(flag==1)
        { se.sprite = s[2];flag = 2;}
        else if(flag ==2)
        { SceneManager.LoadScene("hello");}        
    }
}
