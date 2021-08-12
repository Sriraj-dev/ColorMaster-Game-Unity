using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cscore : MonoBehaviour
{
    static public int score_value=0;
    Text score;
    int highscore;

    // Start is called before the first frame update
    void Start()
    {
        //score_value = 0;
        score = gameObject.GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("c0");
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + score_value;
        if (score_value  > highscore)
        {
            PlayerPrefs.SetInt("c0", score_value);

        }
    }
}
