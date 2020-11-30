using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private int nextLvlLoad;
    
    private void Start()
    {
        nextLvlLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }
    public void LoadNextLvl()
    {
        SceneManager.LoadScene(nextLvlLoad);
        Time.timeScale = 1f;
    }
    public void LoadSelectLvl()
    {
        SceneManager.LoadScene("lvl_select");
        Time.timeScale = 1f;
    }
    public void LoadShop()
    {
        SceneManager.LoadScene("shop");
        Time.timeScale = 1f;
    }
}
