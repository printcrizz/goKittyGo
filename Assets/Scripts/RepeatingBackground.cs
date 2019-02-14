using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    public float groundCollider;
    public float groundVerticalLenght =2f;
    public GameObject starUpper;
    public GameObject starLower;
    public GameObject upper;
    public GameObject lower;
    private float sizee;
	// Use this for initialization
	void Start () {
        groundVerticalLenght = lower.transform.position.y;
        sizee = Mathf.Abs(lower.transform.position.y - upper.transform.position.y);
        //Debug.Log("tamaño: " +sizee);
        //Debug.Log("upper: "+upper.transform.position.y);
        //Debug.Log("lower: " + lower.transform.position.y);
    }
	
	// Update is called once per frame
	void Update () {
        if (starUpper.transform.position.y < groundVerticalLenght)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(0,addingHalfSize() );
        transform.position = groundOffSet;
    }
    float addingHalfSize()
    {
        return (sizee / 2)+1f;
    }
}
