using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelChangerScript : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;
    private IEnumerator Coroutina;
    private bool trig = false;
    // Update is called once per frame

    void Start()
    {
        Debug.Log("estado del trigger " + trig);
        Coroutina = ChangingScene();
        StartCoroutine(Coroutina);
        Debug.Log("estado del trigger 2" + trig);

    }

    void Update()
    {
        if (trig)
        {
            FadeToNextLevel();
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void FadeToNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            fadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    private IEnumerator ChangingScene()
    {
            yield return new WaitForSeconds(7);
            trig = true;
    }
}
