using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatMovement : MonoBehaviour
{
    public float velocity = 10f;
    public float yRotation = 0.0F;
    public float leftDegree = 5.0f;
    public float rightDegree = 5.0f;
    public float zDegree = 5f;
    private IEnumerator coroutine;
    bool isLeft;
    private bool ButtonActive=true;
    Rigidbody2D cat;

    void Start()
    {
        cat = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LeftButton()
    {
        if(ButtonActive){
            Vector2 v2 = new Vector2(-3, 3);
            cat.AddForce(v2 * velocity / 2);
            if (yRotation > -30.0f)
            {
                transform.Rotate(0, 0, rightDegree);
                yRotation += leftDegree;
            }
            cat.AddForce(transform.up * velocity);

        }

    }
    public void RightButton(){
        if(ButtonActive){
            Vector2 v2 = new Vector2(3, 3);
            cat.AddForce(v2 * velocity / 2);
            if (yRotation < 30.0f)
            {
                transform.Rotate(0, 0, leftDegree);
                yRotation += rightDegree;
            }
            cat.AddForce(transform.up * velocity);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cucumber")
        {
            Debug.Log(collision.gameObject.tag);
            Debug.Log("YOU DIED!");
            GetComponent<BoxCollider2D>().enabled=false;
            ButtonActive = false;

            coroutine = WaitAndPrint(3.0f);
            StartCoroutine(coroutine);


            //desactivar botones acá, luego un hilo de 2 segundos y decir has muerto!

            //collision.gameObject.SendMessage("ApplyDamage", 10);
        }
    }
    void CargaEscena(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("corutina  "+waitTime);
        CargaEscena();
    }
}