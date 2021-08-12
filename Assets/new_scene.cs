using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_scene : MonoBehaviour
{
    public Animator transition;
    static public bool move_to_next_scene;
    // Start is called before the first frame update
    void Start()
    {
        move_to_next_scene = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (move_to_next_scene)
        {
            Debug.Log("new_scene ran");
            transition.SetBool("transition_scene", true);move_to_next_scene = false;
            Invoke("f", 1);
        }
    }
  void f()
    {
            transition.SetBool("transition_scene", false);

    }
}
