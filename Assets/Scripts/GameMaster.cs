using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

    public static GameMaster instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public float scrollSpeed2 = -2f;

    public GameObject FlyingCat;
    public int time = -1;
    public Text puntaje;
    private IEnumerator Coroutina;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    // Use this for initialization

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Coroutina = Clock();
        StartCoroutine(Coroutina);
    }

    void Update()
    {

    }

    private IEnumerator Clock()
    {
        while (true)
        {
            time++;
            Debug.Log("tiempo: " + time);
            this.puntaje.text = time.ToString();
            yield return new WaitForSeconds(2.0f);
        }
    }

    public void CatDied(){
        gameOverText.SetActive (true);
        gameOver = true;
    }
 
}
