﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class CucumberMovement : MonoBehaviour {      public Transform points;     public float InvokeRate = 1.0f;     public GameObject[] cube;      // Use this for initialization    void Start () {         InvokeRepeating("pickPoints", 1.0f, InvokeRate);    }       // Update is called once per frame  void pickPoints ()   {     int a = Random.Range(1, cube.Length);      float b = Random.Range(-0.8f, 0.5f);
    Instantiate(cube[a], new Vector2(b,points.position.y), cube[a].transform.rotation);   } }