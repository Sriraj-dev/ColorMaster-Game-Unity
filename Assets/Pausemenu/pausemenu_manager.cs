using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu_manager : MonoBehaviour
{
    public GameObject pausemenu;
    // Start is called before the first frame update
    void Start()
    {
       // Time.timeScale = 1;
        
    }
    public void resume_button()
    {
        Debug.Log("resume clicked");
        pausemenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
        //Debug.Log("TimeScale Set to 0");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
