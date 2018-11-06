using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlayer : MonoBehaviour {

    public GameManager theGameManager;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Destroy(this.gameObject);
            theGameManager.Death();
        }
    }

}


