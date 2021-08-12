using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class musicrandom : MonoBehaviour
{
    public AudioClip[] sounds;
    
    public AudioSource ac;
    void Start()
    {
        int i= Random.Range(0,3);

        ac.clip= sounds[i];
        ac.Play();
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
