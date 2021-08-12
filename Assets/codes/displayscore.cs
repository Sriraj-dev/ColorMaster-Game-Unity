using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displayscore : MonoBehaviour
{
    public string initial_text;
    public bool hscore_or_not;
    public string level_name;
    public int level_number;
    score_saver s;
    public Text text;
    public Text hscore_text;

    int score;
    void Start()
    {
        s = GameObject.FindGameObjectWithTag("highscore").GetComponent<score_saver>();
        score = 0;
    }

    
    void Update()
    {
        int hscore;
        score = Moveup.Score;
         text.text =initial_text+score.ToString();
        Debug.Log("score is : " + score);
        hscore  = PlayerPrefs.GetInt(level_name + level_number.ToString());

        Debug.Log(" hscore is " + hscore);
       hscore_text.text ="HIGH SCORE: "+ hscore.ToString();
        if (hscore < score)
        {
            PlayerPrefs.SetInt(level_name + level_number.ToString(), score);
            Debug.Log(level_name + level_number.ToString() + score.ToString());
        }
      /*  if (hscore_or_not) { text.text = "HIGHSCORE : " + hscore.ToString(); }
        else { text.text = score.ToString(); }*/
    }
}
