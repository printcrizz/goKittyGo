﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjects : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float potenciador = 1f;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, GameMaster.instance.scrollSpeed*potenciador);
	}
	
	// Update is called once per frame
	void Update () {
        if(GameMaster.instance.gameOver == true){
            rb2d.velocity = Vector2.zero;
        }
	}
}
