using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class back_to_menu : MonoBehaviour
{
   public  Admanager a;
    GameObject g;
    // Start is called before the first frame update
    void Start()
    {

        g = GameObject.FindGameObjectWithTag("music");
    }
    void main_menu()
    {
        Destroy(g);

        a.playinterstitialad();
        SceneManager.LoadScene("Gamelist");   }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) 
          {
             Invoke("main_menu", 0.2f); 
          }

    }
}
