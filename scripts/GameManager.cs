using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static bool gameHasEnded = false;
    public GameObject endGameUI;
    public void EndGame() 
    {
        if(gameHasEnded == false) 
        {
            
            endGameUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("GAME OVER");
            gameHasEnded = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameHasEnded == true)
        {
            Debug.Log("Restarting level...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            endGameUI.SetActive(false);
            Time.timeScale = 1f;
            gameHasEnded = false;
        }
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }

}
