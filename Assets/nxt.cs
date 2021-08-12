using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("k",3);
        
    }
   void k()
    {
        SceneManager.LoadScene("Mainmenu");   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
