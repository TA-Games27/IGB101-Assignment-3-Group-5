using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour{
     
     GameManager gameManager;
     AudioSource audioSource;
   
     void Start(){
          gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
          audioSource = GetComponent<AudioSource>();
     }


     private void OnTriggerEnter(Collider otherObject){
          if (otherObject.transform.tag == "Player"){
               audioSource.Play();
               gameManager.currentPickups += 1;
               Destroy(this.gameObject);
          }
     }

}

