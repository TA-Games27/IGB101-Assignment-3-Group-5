using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_door : MonoBehaviour
{
    Animation animation;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        animation = GetComponent<Animation>();
        audioSource = GetComponent<AudioSource>();
    }
        
    // Update is called once per frame
    void Update () {

    if (Input.GetKeyDown("f")){
            animation.Play();
            audioSource.Play();
    }
    }

}
