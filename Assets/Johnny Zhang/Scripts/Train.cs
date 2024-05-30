using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Train : MonoBehaviour{
     
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

