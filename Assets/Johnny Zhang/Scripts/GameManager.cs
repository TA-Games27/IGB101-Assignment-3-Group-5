using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public GameObject player;
    
    //Pickup and Level Completion Logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;
    public int health = 100;

    public Text pickupText;
    public Text healthText;

    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    private void LevelCompleteCheck(){
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    private void UpdateGUI(){
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
        healthText.text = "Health: " + health;
    }

    private void killPlayer(){
        if(health <= 0){
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Reload the current active scene
        SceneManager.LoadScene(currentScene.name);
        }
    }

    void Update(){
        LevelCompleteCheck();
        UpdateGUI();
        killPlayer();  
    }
}
