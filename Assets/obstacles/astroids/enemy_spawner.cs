using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject[] astroids;
    public float delay ;
    private float nexttimetospawn =0f;
    GameObject t;
    public static int Level=1;
    // Start is called before the first frame update
    void Start()
    {
        t= GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        int i = Random.Range(0,Level);
        if (Time.time >= nexttimetospawn)
        {
            Debug.Log("spawned");
            nexttimetospawn = Time.time + delay;
            //Instantiate(astroids[i], new Vector2(t.transform.position.x+Random.Range(-2,2), t.transform.position.y + Random.Range(5, 10)), Quaternion.identity);
            Instantiate(astroids[i], transform.position+new Vector3(0,10,+10),Quaternion.identity);

        }

    }
}
