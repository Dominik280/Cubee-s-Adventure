using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && GameManager.gameHasEnded == false) 
        {
            if(GameisPaused == true) 
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume() 
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void Pause() 
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void LoadMenu() 
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void LoadLevels() 
    {
        SceneManager.LoadScene("lvl_select");
        Time.timeScale = 1f;
        GameisPaused = false;
    }
}
