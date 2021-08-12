using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadlevels : MonoBehaviour
{

   
    // Start is called before the first frame update
    

    public void open1()
    {
        SceneManager.LoadScene("Level1");
        GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);

    }
    public void open2()
    {
        SceneManager.LoadScene("Level2"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open3()
    {
        SceneManager.LoadScene("Level3"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open4()
    {
        SceneManager.LoadScene("Level4"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open5()
    {
        SceneManager.LoadScene("Level5"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open6()
    {
        SceneManager.LoadScene("Level6"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open7()
    {
        SceneManager.LoadScene("Level7"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open8()
    {
        SceneManager.LoadScene("Level8"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open9()
    {
        SceneManager.LoadScene("Level9"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
     public void open10()
    {

        SceneManager.LoadScene("InfiniteLevel"); GameObject k = GameObject.FindGameObjectWithTag("bgm");
        Destroy(k);
    }
    public void goback()
{

    SceneManager.LoadScene("Gamelist");
}
}
