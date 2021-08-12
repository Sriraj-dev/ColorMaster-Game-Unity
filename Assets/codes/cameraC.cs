using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraC : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    Vector3 pos;
    void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player");   

    }

    // Update is called once per frame
    void Update()
    {
        pos.x = 0;
        pos.z = -10;
        pos.y = player.transform.position.y+1;
        transform.position = pos;  
    }
    void FixedUpdate()
    {

    }
}
