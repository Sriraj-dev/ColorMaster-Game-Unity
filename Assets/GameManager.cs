using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Moveup.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Gohome()
    {
        SceneManager.LoadScene("Gamelist");
    }
    public void GoMain()
    {

     SceneManager.LoadScene("Mainmenu");
    }
    public static void Whack_a_mole_lost(int score)
    {
      
        SceneManager.LoadScene("rat_level_completed");

        Debug.Log("GameManager function is running!!");
    }
   static  IEnumerator  waiter(float t)
    {
        yield return new WaitForSeconds(t);
    }
    public static void Whack_a_mole_complete()
    {
        SceneManager.LoadScene("rat_level_completed");

        Debug.Log("GameManager function is running!!");
    }

    public void viewlist()
    {
        SceneManager.LoadScene("Gamelist");
    }
    public void stopgame()
    {
        Application.Quit();
    }
    public static void gamelost()
    {
         //load the lost scene;
         SceneManager.LoadScene("gamelost");
    }
    public static void gamewon()
    {
         SceneManager.LoadScene("gamewon");
        // load the won scene;
    }
    public static void OpenCredits()
    {
       //Load Credits Scene;
        SceneManager.LoadScene("credits");
        Debug.Log("Opening Credits");
     }
}
