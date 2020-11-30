using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadScene("lvl_select");
    }

    public void QuitGame() 
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

    public void Settings() 
    {
        SceneManager.LoadScene("settings");
    }

    public void BackToMenu() 
    {
        SceneManager.LoadScene("menu");
    }

    public void Shop()
    {
        SceneManager.LoadScene("shop");
    }
}
