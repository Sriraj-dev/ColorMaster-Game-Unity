using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highscore : MonoBehaviour
{
    public string level_name;
    public int level_number;
    score_saver s;
    public Text text;
    int hscore;
    // Start is called before the first frame update
    void Start()
    {
        s = GameObject.FindGameObjectWithTag("highscore").GetComponent<score_saver>();

    }

    // Update is called once per frame
    void Update()
    {
        hscore = PlayerPrefs.GetInt(level_name + level_number.ToString());
        text.text = "High score:- " +hscore.ToString();

    }
}
