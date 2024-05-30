using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour{
    
     GameManager gameManager;
   
     void Start(){
     gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
     }


     private void OnTriggerEnter(Collider otherObject){
          if (otherObject.transform.tag == "Player"){
                gameManager.health -= 100;
          }
     }

}
