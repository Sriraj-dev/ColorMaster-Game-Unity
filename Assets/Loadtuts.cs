using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loadtuts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Thunder()
{SceneManager.LoadScene("ThunderTut");}

  //  public void Flashy_balls()
//{SceneManager.LoadScene();}

    public void Mole_Hole()
{SceneManager.LoadScene("Mole_holetut");}

    public void back()
{SceneManager.LoadScene("Gamelist");}
}
