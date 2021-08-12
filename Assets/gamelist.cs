using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamelist : MonoBehaviour
{
    public int total_number_of_scene = 16;
    GameObject[] s;
    // Start is called before the first frame update
    void Start()
    {
         Time.timeScale = 1;
        Moveup.Score = 0;
        Print.current_score = 0;

        cscore.score_value = 0;
        s = GameObject.FindGameObjectsWithTag("music");
        for(int i=0;i<s.Length; i++)
        {
            Destroy(s[i]);
        }
        for(int i = 2; i <= total_number_of_scene; i++)
        {
            SceneManager.UnloadSceneAsync(i);
        }


    }
    public void gyro()
    {
        SceneManager.LoadScene("Levellist");

    }
    public void asteroids()
    {
        SceneManager.LoadScene("astroids");
        GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);

    }
    public void rat()
    {
        SceneManager.LoadScene("Whack-A-Mole");
        GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);


    }
    public void back()
    {
        SceneManager.LoadScene("Mainmenu");
    }
    // Update is called once per frame

   public void Tutorial()
   {
        SceneManager.LoadScene("hello");
   }
    void Update()
    {
        
    }
}
