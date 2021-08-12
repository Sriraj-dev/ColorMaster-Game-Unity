using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    
    public Text text;
    public int secondsleft;
    bool takingaway = false;
    void Start()
    {
        text.text = "00:"+secondsleft;
        
    }

    // Update is called once per frame
    void Update()
    {
        if( secondsleft == 0)
        {
            //call gamemanager;
            Debug.Log("Game is over!!");
            SceneManager.LoadScene("rat_level_completed");

            Debug.Log("You lost");
            new_scene.move_to_next_scene = true;
          //  GameManager.Whack_a_mole_complete();
        }
        if(takingaway == false && secondsleft>0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingaway = true; 
        yield return new WaitForSeconds(1);
        secondsleft -= 1;
        Debug.Log("Seconds left - "+secondsleft);
        text.text = "00:"+secondsleft;
        takingaway = false;
    }
}
