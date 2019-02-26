using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerScript : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
        fadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
