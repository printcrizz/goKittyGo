using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsMovement : MonoBehaviour {
    public float speed = 2.0f; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, speed * Time.deltaTime, 0);

        //transform.position = new Vector3(transform.position.x , transform.position.y * speed,transform.position.z);
    }
}
