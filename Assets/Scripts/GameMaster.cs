using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    public static GameMaster instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed;
    public float scrollSpeed2;
    public GameObject PantallaMuerte;
    public GameObject score;

    public GameObject FlyingCat;
    public int time = -1;
    public Text puntaje;
    private IEnumerator Coroutina;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    // Use this for initialization
    private Text scoore;

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
        scoore = score.GetComponent<Text>();
        
    }

    void Update()
    {

    }

    private IEnumerator Clock()
    {
        while (!gameOver)
        {
            time++;
            //Debug.Log("tiempo: " + time);
            puntaje.text = time.ToString();
            yield return new WaitForSeconds(2.0f);
        }
    }

    public void CatDied(){
       // gameOverText.SetActive (true);
        gameOver = true;
        scoore.text = puntaje.text;
        PantallaMuerte.SetActive(true);
        puntaje.gameObject.SetActive(false);
        GetComponentInChildren<HighScores>().UpdateHS();
        //GO.SetActive(true);

    }
    public void CargaEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
