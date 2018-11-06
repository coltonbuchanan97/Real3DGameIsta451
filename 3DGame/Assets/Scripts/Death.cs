using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public int scoreValue;
    private GameManager gameManager;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameManager");
        if (gameControllerObject != null)
        {
            gameManager = gameControllerObject.GetComponent<GameManager>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if (other.tag == "Player")
        {
            gameManager.EndGame();
        }
        gameManager.AddScore(scoreValue);

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}

