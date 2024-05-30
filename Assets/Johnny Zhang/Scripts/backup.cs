using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattach : MonoBehaviour
{	
	public GameObject Player;

    private void Start()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            Player = gameManager.player;
        }
        else
        {
            Debug.LogError("GameManager not found in the scene!");
        }
    }

	private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject == Player)
		{
			Player.transform.parent = transform;
		}
	}

	private void OnCollisionExit(Collision other)
	{
		if(other.gameObject == Player)
		{
			Player.transform.parent = null;
		}
	}
}
