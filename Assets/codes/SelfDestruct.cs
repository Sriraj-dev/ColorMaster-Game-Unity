using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("player.position.y is "+player.position.y );
        if(transform.position.y < player.position.y - 5)
        {
            Destroy(gameObject);
        }
    }
}
