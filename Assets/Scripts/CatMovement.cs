using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatMovement : MonoBehaviour
{
    public float velocity = 1f;
    public float velocityX = 1f;
    public float yRotation = 0.0F;
    public float leftDegree = 5.0f;
    public float rightDegree = 5.0f;
    public float zDegree = 5f;
    public float enumeratorR = 0f;
    public float enumeratorL = 0f;
    private IEnumerator coroutine;
    bool isLeft;

    public GameMaster GM;
    public AudioSource pepinoHit;

    public bool PresionBotonIzquierdo;
    public bool PresionBotonDerecho;

    private float Laux = 0.0f;
    private float Raux = 0.0f;

    public bool ButtonActive=true;
    Rigidbody2D cat;

    void Start()
    {
        PresionBotonDerecho = false;
        PresionBotonIzquierdo = false;
        cat = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        RightButton();
        LeftButton();
    }

    public void LeftButton()
    {
        enumeratorR = 0f;
        if (ButtonActive && PresionBotonIzquierdo){
            Laux += 0.01f;
            enumeratorL += Mathf.Clamp(Laux, 0f,1f );
            Vector2 v2 = new Vector2(-1*Mathf.Sqrt(enumeratorL) * 2, 1f);
            Debug.Log("enumerator izquierda: " + enumeratorL);
            cat.AddForce(v2 * velocity);
            if (yRotation > -30.0f)
            {
                transform.Rotate(0, 0, rightDegree);
                yRotation += leftDegree;
            }
            cat.AddForce(transform.up * velocityX);

        }

    }
    public void RightButton(){
        enumeratorL = 0f;
        if (ButtonActive && PresionBotonDerecho){
            Raux += 0.01f;
            enumeratorR = Mathf.Clamp(Raux, 0f, 1f);
            Vector2 v2 = new Vector2(Mathf.Sqrt(enumeratorR)*2, 1f);
            Debug.Log("enumerator derecha: " + enumeratorR);
            cat.AddForce(v2 * velocity);
            if (yRotation < 30.0f)
            {
                transform.Rotate(0, 0, leftDegree);
                yRotation += rightDegree;
            }
            cat.AddForce(transform.up * velocityX);
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
            pepinoHit.Play();
            coroutine = WaitAndPrint(1.0f);
            StartCoroutine(coroutine);


            //desactivar botones acá, luego un hilo de 2 segundos y decir has muerto!

            //collision.gameObject.SendMessage("ApplyDamage", 10);
        }
    }



    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("corutina  "+waitTime);
        GM.CatDied();
        //PantallaMuerte.SetActive(true);
        //CargaEscena();
    }
    public void RActivator(bool a) {
        PresionBotonDerecho = a;
    }
    public void LActivator(bool a)
    {
        PresionBotonIzquierdo = a;
    }
}