using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public float velocity = 1.0f;
    private IEnumerator coroutine;
    private bool isStarted = false;
    private Vector3 uspted;

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = transform.position -;
        coroutine = WaitAndPrint(5.0f);
        StartCoroutine(coroutine);
        print("despues de la corutina");
    }
    void Update()
    {
        if(isStarted){
            uspted = new Vector3(0, velocity/10f, 0);
            transform.position = transform.position + uspted;
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("corutina  "+waitTime);
            isStarted = true;
    }
}
