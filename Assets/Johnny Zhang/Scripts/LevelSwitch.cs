using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitching : MonoBehaviour
{
    GameManager gameManager;
    public string nextLevel;


    // Start is called before the first frame update
    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void OnTriggerEnter(Collider otherObject){

        if (otherObject.transform.tag == "Player"){

            if(gameManager.levelComplete){
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
