using UnityEngine;

public class LvlComplete : MonoBehaviour
{
    public GameObject WinMenuUI;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        WinMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
