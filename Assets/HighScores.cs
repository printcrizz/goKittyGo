using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text score;
    public Text highScore;
    public int number;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void UpdateHS()
    {
        number = System.Int32.Parse(score.text);
        //score.text = number.ToString();

        Debug.Log("puntaje impreso desde HS: "+number);
        if(number > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();

            Debug.Log("imprimiendo HS: " + highScore.text);

        }
    }
}
