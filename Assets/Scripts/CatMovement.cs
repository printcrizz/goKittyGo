using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float velocity = 10f;
    public float yRotation = 30.0F;
    public float leftDegree = 5.0f;
    public float rightDegree = 5.0f;
    public float zDegree = 5f;
    bool isLeft;
    Rigidbody2D cat;

    void Start()
    {
        cat = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(1))
        {
            Vector3 dir = Quaternion.AngleAxis(70, Vector3.forward) * Vector3.right;
            cat.AddForce(dir * velocity);
            //if (isLeft)
            transform.Rotate(0,0,leftDegree);
                //yRotation += rightDegree;
            //transform.eulerAngles = new Vector3(0, 0, -yRotation);
            //cat.AddForce(transform.up * velocity);
        }
        if (Input.GetMouseButtonDown(0))
        {
            LeftButton();
            //cat.AddForce(transform.up * velocity);
        }
    }

    public void LeftButton()
    {
        Vector3 dir = Quaternion.AngleAxis(110, Vector3.forward) * Vector3.right;
        cat.AddForce(dir * velocity);
        transform.Rotate(0, 0, rightDegree);
        //yRotation += leftDegree;

        //transform.eulerAngles = new Vector3(0, 0, yRotation);
    }
   }
