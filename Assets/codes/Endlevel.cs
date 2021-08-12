using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endlevel : MonoBehaviour
{
    public string level_name;
    public int level_number;
    public Transform Player;
    public ParticleSystem blast;
   // public GameObject GameWon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.position.y >= transform.position.y)
        {
            score_saver.level_name = level_name;
            score_saver.level_number = level_number;
            
           // Instantiate(GameWon,transform.position,Quaternion.identity);
          // Debug.Log("Hello");
           Instantiate(blast,transform.position,Quaternion.identity);
           Invoke ("call",1f);
           
            Debug.Log("GameOver");
        }
    }
    void call()
    {
        SceneManager.LoadScene("gamewon");
        GameManager.gamewon();
    }
}
