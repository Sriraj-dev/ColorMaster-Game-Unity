using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 a---> gyro and button
b----> rat
c---->thunder

sucseded by level numbers ,( 0 for infinity)

this is used only to store the highscore and not the instantanious score
 

example , gyro level 1  ---------------->    a1     ,  if a1=-1   implies the level is not yet unlocked

 */

public class score_saver : MonoBehaviour
{
    int s;

    public SpriteRenderer sr;
    public Sprite amazing;
    public Sprite win;
    public Sprite lose;
    public Sprite well_tried;
    public Text hscore;
    public Text Score;

    public static string level_name;
    public static int level_number;

    int first_time;
    // Start is called before the first frame update
    public void Start()
    {
        first_time=PlayerPrefs.GetInt("first_time");
        Debug.Log("first time  "+first_time);
        if (first_time == 0)
        {
            for(int i = 0; i < 10; i++)
            {
                if (i == 1) { PlayerPrefs.SetInt("a" + i, 0); }// only level 1 is unlocked
                else { PlayerPrefs.SetInt("a" + i, -1); }// minus1 was kept as the game was opened first time , all the levels have not yet been unlocked
                
            }
            PlayerPrefs.SetInt("b", 0);  // as b and c are infinite levels we only kept one
            PlayerPrefs.SetInt("c", 0);
            PlayerPrefs.SetInt("first_time", 1);// so that if condition is never run again

        }
    }
    public void add_high_score(string level_name,int level_number,int highscore)
    {
        PlayerPrefs.SetInt(level_name + level_number.ToString(), highscore);
    }
    public int get_high_score(string level_name, int level_number)
    {
        int highscore;
        highscore = PlayerPrefs.GetInt(level_name + level_number.ToString());
        return highscore;
    }
   public  void add_to_total_points(int points)
    {

        PlayerPrefs.SetInt("total_points", PlayerPrefs.GetInt("total_points")+points);
    }
    public int get_total_points()
    {
        int points = PlayerPrefs.GetInt("total_points");
        return points;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("level is " + level_name+"-" + level_number);
     
        {
            int k= PlayerPrefs.GetInt(level_name + level_number.ToString());
            Debug.Log("hscore: " + k);

            hscore.text ="HIGH SCORE : "+ k;
        
        
        
            if (level_name == "c")
            {
                Score.text = "SCORE : "+cscore.score_value;
                s = cscore.score_value;
            }
            if (level_name == "a")
            {
                Score.text = "SCORE : " + Print.current_score;
                s = Print.current_score;
            }
            if (level_number == 0)
            {if (s >= k) { sr.sprite = amazing; }
              else {
                            sr.sprite = well_tried;
                        }
            }
            else
            {
                if (s >= k&& s>0) { sr.sprite = win; }
                else { sr.sprite = lose; }
            }

        }

        
    }
}
