using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_spawner : MonoBehaviour
{
    public GameObject to_be_spawned;
    public float spawnrate = 1f;
    private float nexttimetospawn = 2f;
    GameObject t;
    // Start is called before the first frame update
    void Start()
    {
        t= GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nexttimetospawn)
        {
            nexttimetospawn = Time.time + 1f / spawnrate;
            Instantiate(to_be_spawned, new Vector2(t.transform.position.x+Random.Range(-2,2), t.transform.position.y + Random.Range(3, 5)), Quaternion.identity);


        }

    }
}
