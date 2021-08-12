using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collisionC : MonoBehaviour
{
    public GameObject plus5;
    public GameObject gameover;
    public GameObject player;
    public ParticleSystem blast;
     Sprite blast_sprite;
    public Sprite[] s;
    
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void to_nxr_scene()
    {
        SceneManager.LoadScene("gamewon");
    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
         Debug.Log(Collider.tag);

         if(gameObject.tag == Collider.tag)
        {
            cscore.score_value += 5;
            Debug.Log("5 is added and score_value changed to "+cscore.score_value);
            Debug.Log("collision detected with tag "+gameObject.tag);
           blast.startColor=playerC.current_color;

            Instantiate(plus5, transform.position, Quaternion.identity);
            Instantiate(blast, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
        else
         {
            Instantiate(gameover, transform.position , Quaternion.identity);
           blast.startColor=playerC.current_color;
          //  blast.textureSheetAnimation.SetSprite(0, blast_sprite);
            Instantiate(blast, transform.position, Quaternion.identity);
            playerC.dead = true;
            Invoke("to_nxt_scene",2);
         }
    }
}
