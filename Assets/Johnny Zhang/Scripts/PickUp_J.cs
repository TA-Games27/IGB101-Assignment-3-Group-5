using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_J : MonoBehaviour{
     
     GameManager_J gameManager;
     AudioSource audioSource;
   
     void Start(){
          gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_J>();
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

