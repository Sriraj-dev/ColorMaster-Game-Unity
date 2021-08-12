using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Print : MonoBehaviour
{
    // Start is called before the first frame update public string level_name;
    public string level_name;
    public int level_number;
    score_saver s;
    public static int current_score=0;
    public Text text;
    int hscore;

    void Start()
    {
        s = GameObject.FindGameObjectWithTag("highscore").GetComponent<score_saver>();
        Debug.Log("added level number : " + level_name + level_number);
        score_saver.level_name = level_name;
        score_saver.level_number = level_number;
    }

    // Update is called once per frame
    void Update()
    {
        score_saver.level_name = level_name;
        score_saver.level_number = level_number;
        //text.text = "Hello";
        text.text = current_score.ToString();
        hscore = PlayerPrefs.GetInt(level_name + level_number.ToString());

//hscore = s.get_high_score(level_name, level_number);
        Debug.Log("the highscore is "+ hscore);
        if (hscore < current_score)
        {
            
            PlayerPrefs.SetInt(level_name + level_number.ToString(), current_score);
       //     s.add_high_score(level_name, level_number, current_score);
            Debug.Log(level_name + level_number.ToString() + current_score.ToString());
        }
    }

    public void TakeScore(int score)
    {
        current_score = score;      
    }
}
