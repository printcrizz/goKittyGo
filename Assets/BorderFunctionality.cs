using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFunctionality : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gatito;

    public GameMaster GM;
    private IEnumerator coroutine;

    public AudioSource sonidomuerte;
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gatito.GetComponent<CatMovement>().ButtonActive = false;
            Debug.Log(collision.gameObject.tag);
            Debug.Log("HE CHOCADO CON EL BORDE!");
            sonidomuerte.Play();

            //GM.CatDied();
            //GetComponent<BoxCollider2D>().enabled = false;
            //GameMaster.ButtonActive = false;

            coroutine = WaitAndPrint(1.0f);
            StartCoroutine(coroutine);

        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("corutina  " + waitTime);
        GM.CatDied();
        //PantallaMuerte.SetActive(true);
        //CargaEscena();
    }
}
