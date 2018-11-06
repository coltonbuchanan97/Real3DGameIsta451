using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public MainMenu theDeathScreen;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        theDeathScreen.gameObject.SetActive(false);   
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Death()
    {
        theDeathScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
