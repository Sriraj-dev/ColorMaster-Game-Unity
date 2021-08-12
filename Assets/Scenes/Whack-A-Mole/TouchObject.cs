using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.Log("Hello");
        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log("bye");
            if(hit.collider !=null)
            {
                Debug.Log("Kaam kar na ");
            }
            Debug.Log( "hitten to"+ hit.transform.name);
        }

        }
        
    }
}
