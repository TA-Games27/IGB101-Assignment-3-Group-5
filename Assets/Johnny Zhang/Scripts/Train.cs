using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Train : MonoBehaviour{
     
     GameManager_J gameManager;
   
     void Start(){
     gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_J>();
     }


     private void OnTriggerEnter(Collider otherObject){
          if (otherObject.transform.tag == "Player"){
                gameManager.health -= 100;
          }
     }

}

