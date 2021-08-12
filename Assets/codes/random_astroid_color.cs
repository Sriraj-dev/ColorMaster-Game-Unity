using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_astroid_color : MonoBehaviour
{
    public  SpriteRenderer sr;
    public Color yellow;
    public Color cyan;
    public Color magenta;
    public Color purple;

    static public bool change_astroid_color;

    // Start is called before the first frame update
    void Start()
    {
        randomcolor();
        change_astroid_color = false;
      //  sr = this.gameObject.GetComponent<SpriteRenderer>();
    }
    public void randomcolor()
    {
       
        Debug.Log("random color  function ran");
        int i;
        i = Random.Range(0, 4);
        switch (i)
        {
            case 0:
                sr.color = yellow;
                this.gameObject.tag = "yellow";
                break;
            case 1:
                sr.color = magenta;
                this.gameObject.tag = "magenta";

                break;
            case 2:
                sr.color = cyan;
                this.gameObject.tag = "cyan";

                break;
            case 3:
                sr.color = purple;
                this.gameObject.tag = "purple";

                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (change_astroid_color == true)
        {
            Debug.Log("random astroid ran in update ");
            Debug.Log("random color  function ran");
            int i;
            i = Random.Range(0, 4);
            switch (i)
            {
                case 0:
                    sr.color = yellow;
                    this.gameObject.tag = "yellow";
                    break;
                case 1:
                    sr.color = magenta;
                    this.gameObject.tag = "magenta";

                    break;
                case 2:
                    sr.color = cyan;
                    this.gameObject.tag = "cyan";

                    break;
                case 3:
                    sr.color = purple;
                    this.gameObject.tag = "purple";

                    break;
            }
        }
        


    }
}
