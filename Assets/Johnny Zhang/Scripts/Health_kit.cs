using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_kit : MonoBehaviour
{   
     GameManager gameManager;
     AudioSource audioSource;
     // Start is called before the first frame update
     void Start(){
          gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
          audioSource = GetComponent<AudioSource>();
          }


     private void OnTriggerEnter(Collider otherObject){
          if (otherObject.transform.tag == "Player"){
                              audioSource.Play();
               gameManager.health = 100;
               Destroy(this.gameObject);
          }
     }

}
