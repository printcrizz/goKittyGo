using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCucumber : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DestroyObjectDelayed();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 7);
    }
}
