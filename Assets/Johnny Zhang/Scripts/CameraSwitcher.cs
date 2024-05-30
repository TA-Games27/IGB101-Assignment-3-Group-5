using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;
        }
    }

}
